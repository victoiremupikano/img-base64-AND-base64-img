using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64.Services
{
    class ImgServices
    {
        public PictureBox pic { get; set; }

        // var pour retourner le filename
        public string filename { get; set; }

        public PictureBox Take()
        {
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Filter = "Choisir une image(*.jpg; *.png; *.gif; *.ico)|*.jpg; *.png; *.gif; *.ico";
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.Image = Image.FromFile(openPic.FileName);
                // on sauvegarde le filename
                filename = openPic.FileName;
            }
            else { }
            return pic;
        }

        public byte[] encoding_img()
        {
            //iMAGE 
            MemoryStream ms = new MemoryStream();
            pic.Image.Save(ms, pic.Image.RawFormat);
            byte[] img = ms.ToArray();
            return img;
        }

        public Image decoding_img(Byte[] var)
        {
            Image result;
            MemoryStream ms = new MemoryStream(var);
            result = Image.FromStream(ms);
            return result;
        }

        // Cette méthode transforme une chaîne de caractère en bytes
        public byte[] transformeEnBytes(string maChaine)
        {
            byte[] bytes = new byte[maChaine.Length * sizeof(char)];
            System.Buffer.BlockCopy(maChaine.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        // cette methode transforme base64 a image
        public Image loardImage(string base64, string ext)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
    }
}
