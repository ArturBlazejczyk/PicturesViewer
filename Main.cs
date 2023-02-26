using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesViewer
{
    public partial class Main : Form
    {
        private string imagePath;
        private string storedImagePath = Environment.CurrentDirectory + "storedImagePath.txt";
        public Main()
        {
            InitializeComponent();
            ShowLastUsedImage();
        }

        private void ShowLastUsedImage()
        {
            pbox.ImageLocation = File.ReadAllText(storedImagePath);
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            var pictureHelper = new ImageHelper();
            imagePath = pictureHelper.UploadImage();
            pictureHelper.SaveLastImage(imagePath, storedImagePath);

            pbox.ImageLocation = imagePath;
        }

        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            var pictureHelper = new ImageHelper();
            pictureHelper.SaveLastImage(String.Empty, storedImagePath);

            pbox.ImageLocation = null;
            btnDeletePicture.Visible = false;
        }

        private void pbox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnDeletePicture.Visible = true;
        }
    }
}
