using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Resources;
using System.Text;
using Tesseract;
using System.IO;

namespace BNSBan
{
    /*
        (24.34~43.18) / 67.73
        36% ~ 64%

        (2.68~3.67) / 38.1
        7% ~ 9.6%
    */
    class Util
    {
        TesseractEngine ocr = null;
        public Util()
        {
            ocr = new TesseractEngine("./tessdata","eng");
            Directory.CreateDirectory("./adtemp");
        }

        public List<string> ocrDetectString(string filename)
        {
            List<string> result = new List<string>();
            if(ocr == null)
            {
                return result;
            }
            Pix pix = Pix.LoadFromFile(filename);
            if (pix == null)
            {
                return result;
            }
            Page page = ocr.Process(pix);
            Pix processed = page.GetThresholdedImage();
            processed.Save("./adtemp/process.png");
            string text = page.GetText();
            using (var iter = page.GetIterator())
            {
                iter.Begin();
                do
                {
                    do
                    {
                        do
                        {
                            do
                            {
                                if (iter.IsAtBeginningOf(PageIteratorLevel.Block))
                                {
                                    Console.WriteLine("<BLOCK>");
                                }

                                Console.Write(iter.GetText(PageIteratorLevel.Word));
                                Console.Write(" ");

                                if (iter.IsAtFinalOf(PageIteratorLevel.TextLine, PageIteratorLevel.Word))
                                {
                                    Console.WriteLine();
                                }
                            } while (iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));

                            if (iter.IsAtFinalOf(PageIteratorLevel.Para, PageIteratorLevel.TextLine))
                            {
                                Console.WriteLine();
                            }
                        } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
                    } while (iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
                } while (iter.Next(PageIteratorLevel.Block));
            }
            Console.WriteLine(text);
            result.Add(text);
            page.Dispose();
            pix.Dispose();
            return result;
        }

        private Rectangle searchBitmap(Bitmap smallBmp, Bitmap bigBmp, double tolerance)
        {
            BitmapData smallData =
              smallBmp.LockBits(new Rectangle(0, 0, smallBmp.Width, smallBmp.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format24bppRgb);
            BitmapData bigData =
              bigBmp.LockBits(new Rectangle(0, 0, bigBmp.Width, bigBmp.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format24bppRgb);

            int smallStride = smallData.Stride;
            int bigStride = bigData.Stride;

            int bigWidth = bigBmp.Width;
            int bigHeight = bigBmp.Height - smallBmp.Height + 1;
            int smallWidth = smallBmp.Width * 3;
            int smallHeight = smallBmp.Height;

            Rectangle location = Rectangle.Empty;
            int margin = Convert.ToInt32(255.0 * tolerance);

            unsafe
            {
                byte* pSmall = (byte*)(void*)smallData.Scan0;
                byte* pBig = (byte*)(void*)bigData.Scan0;

                int smallOffset = smallStride - smallBmp.Width * 3;
                int bigOffset = bigStride - bigBmp.Width * 3;

                bool matchFound = true;

                for (int y = 0; y < bigHeight; y++)
                {
                    for (int x = 0; x < bigWidth; x++)
                    {
                        byte* pBigBackup = pBig;
                        byte* pSmallBackup = pSmall;

                        //Look for the small picture.
                        for (int i = 0; i < smallHeight; i++)
                        {
                            int j = 0;
                            matchFound = true;
                            for (j = 0; j < smallWidth; j++)
                            {
                                //With tolerance: pSmall value should be between margins.
                                int inf = pBig[0] - margin;
                                int sup = pBig[0] + margin;
                                if (sup < pSmall[0] || inf > pSmall[0])
                                {
                                    matchFound = false;
                                    break;
                                }

                                pBig++;
                                pSmall++;
                            }

                            if (!matchFound) break;

                            //We restore the pointers.
                            pSmall = pSmallBackup;
                            pBig = pBigBackup;

                            //Next rows of the small and big pictures.
                            pSmall += smallStride * (1 + i);
                            pBig += bigStride * (1 + i);
                        }

                        //If match found, we return.
                        if (matchFound)
                        {
                            location.X = x;
                            location.Y = y;
                            location.Width = smallBmp.Width;
                            location.Height = smallBmp.Height;
                            break;
                        }
                        //If no match found, we restore the pointers and continue.
                        else
                        {
                            pBig = pBigBackup;
                            pSmall = pSmallBackup;
                            pBig += 3;
                        }
                    }

                    if (matchFound) break;

                    pBig += bigOffset;
                }
            }

            bigBmp.UnlockBits(bigData);
            smallBmp.UnlockBits(smallData);
            return location;
        }

        public string DetectDetailPage(string filename)
        {
            try
            {
                Bitmap pivot = Resources.AutoDetect.pivot;
                Bitmap screenshot = new Bitmap(filename);
                Rectangle search = searchBitmap(pivot, screenshot, 0.1);
                if (search == Rectangle.Empty)
                {
                    pivot.Dispose();
                    screenshot.Dispose();
                    return "";
                }
                //264 (288),534 ()-> {X=467,Y=218,Width=137,Height=37} x+67, y+46 -> x+567, y+70
                Rectangle modified = new Rectangle(search.X + 67, search.Y + 46, 500, 24);
                Bitmap crop = screenshot.Clone(modified, screenshot.PixelFormat);
                crop.Save("./adtemp/crop.jpg");
                List<String> str = ocrDetectString("./adtemp/crop.jpg");
                pivot.Dispose();
                screenshot.Dispose();
                crop.Dispose();
                return str[0];
            }catch(Exception)
            {
                return "";
            }
        }

        public string DetectDetailPage()
        {
            Bitmap pivot = Resources.AutoDetect.pivot;
            ScreenCapture capture = new ScreenCapture();
            Bitmap screenshot = capture.Capture();
            Rectangle search = searchBitmap(pivot, screenshot, 0.1);
            if (search == Rectangle.Empty)
            {
                pivot.Dispose();
                screenshot.Dispose();
                return "";
            }
            //264 (288),534 ()-> {X=467,Y=218,Width=137,Height=37} x+67, y+46 -> x+567, y+70
            Rectangle modified = new Rectangle(search.X + 67, search.Y + 46, 500, 24);
            Bitmap crop = screenshot.Clone(modified, screenshot.PixelFormat);
            crop.Save("./adtemp/crop.jpg");
            List<String> str = ocrDetectString("./adtemp/crop.jpg");
            pivot.Dispose();
            screenshot.Dispose();
            crop.Dispose();
            return str[0];
        }
    }

    public class ButtonImageSet
    {
        public Bitmap normal;
        public Bitmap hover;
    }

    static class AltCode
    {
        public static Dictionary<char, List<char>> alttable = new Dictionary<char, List<char>>()
        {
            {'A', new List<char>(){ 'â', 'ä', 'à', 'å', 'á', 'æ', 'œ', 'ã', 'À', 'Á', 'Â', 'Ã', 'Ä', 'Æ', 'Å' } },
            {'E', new List<char>(){ 'é', 'ê', 'ë', 'è', 'Œ', 'æ', 'œ', 'È', 'É', 'Ê', 'Ë', 'Œ', 'Æ' } },
            {'I', new List<char>(){ 'ï', 'î', 'ì', 'í', '¡', 'Ì', 'Í', 'Î', 'Ï' } },
            {'O', new List<char>(){ 'ô', 'ö', 'ò', 'ó', '°' , '•' , '·' , '‰', 'ð', 'õ', 'ø', 'þ', 'Ò', 'Ó', 'Ô', 'Õ', 'Ö', 'Ø' } },
            {'U', new List<char>(){ 'û', 'ù', 'ú', 'µ', 'ü', 'Ù', 'Ú', 'Û', 'Ü' } },
            {'P', new List<char>(){ 'P', 'Þ', 'þ'} },
            {'F', new List<char>(){ 'ƒ'} },
            {'N', new List<char>(){ 'ñ', 'Ñ' } },
            {'S', new List<char>(){ 'š', 'Š' } },
            {'Y', new List<char>(){ 'ÿ', 'ý', 'Ÿ', 'Ý' } },
            {'D', new List<char>(){ 'Ð' } },
            {'+', new List<char>(){ '†', '±', '‡' } },
            {'3', new List<char>(){ 'ß', '³', '¾' } },
        };

    }
}
