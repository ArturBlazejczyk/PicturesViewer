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
            ShowLastUsedPicture(storedImagePath);
        }

        private void ShowLastUsedPicture(string storedImagePath)
        {
            pbox.ImageLocation = File.ReadAllText(storedImagePath);
        }

        private void RememberLastPicture(string imagePath)
        {
            if (!File.Exists(storedImagePath))
                File.Create(storedImagePath);

            File.WriteAllText(storedImagePath, imagePath);
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "image files (*.jpg)|*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                }
            }

            RememberLastPicture(imagePath);
            pbox.ImageLocation = imagePath;
        }

        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            pbox.ImageLocation = null;
            RememberLastPicture(String.Empty);
            btnDeletePicture.Visible = false;
        }

        private void pbox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnDeletePicture.Visible = true;
        }
    }
}
