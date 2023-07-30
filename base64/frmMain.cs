using base64.Properties;
using base64.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64
{
    public partial class frmMain : Form
    {
        public string file, ext = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImgToBase64_Click(object sender, EventArgs e)
        {
            var base64Img = new Base64Image
            {
                FileContents = File.ReadAllBytes(file),
                ContentType = $"image/{ext}"
            };

            string base64EncodedImg = base64Img.ToString();
            txtBase64ToImg.Text = txtImgToBase64.Text = base64EncodedImg;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //on verifie le dernier preference de l'utilisateur lors de la fermeture du logiciel
            if (Settings.Default.closingState == "Minimized")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (Settings.Default.closingState == "Maximized")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (Settings.Default.closingState == "Normal")
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Settings.Default.closingState = "Minimized";
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                Settings.Default.closingState = "Maximized";
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.closingState = "Normal";
            }
            Settings.Default.Save();
            Application.Exit();
        }

        private void btnBase64ToImg_Click(object sender, EventArgs e)
        {
            string ext = txtBase64ToImg.Text.Split(';')[0].Split('/')[1];
            string base64 = txtBase64ToImg.Text.Split(',')[1];

            Services.ImgServices img = new ImgServices();
            picImage2.Image = img.loardImage(base64, ext);
        }

        private void txtImgToBase64_TextChanged(object sender, EventArgs e)
        {
            lblNbrChar1.Text = txtImgToBase64.Text.Length.ToString();
        }

        private void txtBase64ToImg_TextChanged(object sender, EventArgs e)
        {
            lblNbrChar2.Text = txtBase64ToImg.Text.Length.ToString();
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            Services.ImgServices picture = new Services.ImgServices();
            picture.pic = picImage1;
            picImage1 = picture.Take();
            // on recupere le filename de l'oimage
            file = picture.filename;
            MessageBox.Show(file);
            //recperation de l'extension
            var separeted = file.Split('.');
            ext = separeted[1];

            txtBase64ToImg.Text = txtImgToBase64.Text = string.Empty;
        }
    }
}
