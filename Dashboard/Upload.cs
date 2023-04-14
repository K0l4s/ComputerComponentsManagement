using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dashboard
{
    public static class Upload
    {
        public static string resourcesFolder = "Resources";
        public static string appDirectory = Application.StartupPath;
        public static string parentDirectory = Directory.GetParent(Directory.GetParent(appDirectory).FullName).FullName;
        public static string resourcesFolderPath = Path.Combine(parentDirectory, resourcesFolder);


        public static string SaveImageToResources(PictureBox picturebox ) {
            string pathResult = null ; 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                //Random name by datetime created
                string imageName = string.Format("{0:yyyyMMddHHmmssfff}_{1}", DateTime.Now, Guid.NewGuid());
                string imageExtension = Path.GetExtension(imagePath);
                string destinationPath = Path.Combine(resourcesFolderPath, imageName + imageExtension);
                File.Copy(imagePath, destinationPath, true);

                picturebox.Image = Image.FromFile(destinationPath);
                pathResult = destinationPath ;
                MessageBox.Show($"Upload image thanh cong !");
            }
            return pathResult;
        }
        public static string GetImageName(string fullpath) {
            string name = Path.GetFileName(fullpath);
            if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
                MessageBox.Show("File path does not exist !!!");

            return name;
        }

        public static string GetFullImgPath(string filename) {
            string name = null;
            string fullpath =  resourcesFolderPath + filename ;
            if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
                MessageBox.Show("File path does not exist !!!");
            return name;
        }
    }
}
