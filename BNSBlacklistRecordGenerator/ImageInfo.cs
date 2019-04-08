using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNSBlacklistRecordGenerator
{
    class ImageInfo
    {
        ImageList ilist = new ImageList();
        List<string> urllist = new List<string>();
        List<string> dlist = new List<string>();
        private int count = 0;

        public ImageInfo()
        {
            ilist.ImageSize = new Size(64, 64);
        }

        public int AddImage(string url, string title)
        {
            Image image;
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;
                WebResponse webResponse = webRequest.GetResponse();
                Stream stream = webResponse.GetResponseStream();
                image = Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                return -1;
            }
            if (image != null)
            {
                ilist.Images.Add(image);
                urllist.Add(url);
                dlist.Add(title);
                return count++;
            }
            return -1;
        }

        public Image GetImage(int index)
        {
            if (index >= count || index < 0)
            {
                return null;
            }
            return ilist.Images[index];
        }

        public string GetURL(int index)
        {
            if (index >= count || index < 0)
            {
                return null;
            }
            return urllist[index];
        }

        public string GetTitle(int index)
        {
            if (index >= count || index < 0)
            {
                return null;
            }
            return urllist[index];
        }

        public bool RemoveImage(int index)
        {
            if (index >= count || index < 0)
            {
                return false;
            }
            ilist.Images.RemoveAt(index);
            dlist.RemoveAt(index);
            urllist.RemoveAt(index);
            count--;
            return true;
        }

        public bool RemoveImage(string url)
        {
            int index = urllist.IndexOf(url);
            return RemoveImage(index);
        }

        public int Count()
        {
            return count;
        }

        public ImageList GetImageList()
        {
            return ilist;
        }
    }
}
