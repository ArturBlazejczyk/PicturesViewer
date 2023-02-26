using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesViewer
{
    public class ImageHelper
    {
        public void SaveLastImage(string imagePath, string storedImagePath)
        {
            if (!File.Exists(storedImagePath))
                File.Create(storedImagePath);

            File.WriteAllText(storedImagePath, imagePath);
        }

        public string UploadImage()
        {
            string imagePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "image files (*.jpg)|*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                }
                return imagePath;
            }
        }
    }
}
