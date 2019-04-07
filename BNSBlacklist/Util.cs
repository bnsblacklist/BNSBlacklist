using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
//using Tesseract;
//using tessnet2;

namespace BNSBan
{
    class Util
    {
        /*Tesseract ocr = null;
        public Util()
        {
            ocr = new Tesseract();
            ocr.Init("./tessdata", "eng", false);
        }

        public List<string> detectLobby(string filename)
        {
            List<string> result = new List<string>();
            if(ocr == null)
            {
                return result;
            }
            Bitmap img = new Bitmap(filename);
            if (img == null)
            {
                return result;
            }
            List<tessnet2.Word> w = ocr.DoOCR(img, Rectangle.Empty);
            foreach(tessnet2.Word word in w)
            {
                result.Add(word.Text + " - " + word.Confidence + "\n");
            }
            return result;
        }*/
    }

    class ButtonImageSet
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
