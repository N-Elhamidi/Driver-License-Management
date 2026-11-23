using System;

namespace DVLD.Global
{
    public static class clsUtil
    {
        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }
        public static bool CreateFolderIfDoesNotExist(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    return true;
                }
                catch(Exception e )
                {
                    MessageBox.Show("Error Creating a Folder: " + e.Message);
                    return false;
                }
                
            }
            return true;
        }

        public static string GetReplacedFileNameGUID(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);

            return GenerateGUID() + fileInfo.Extension;
        }

        public static bool CopyImageToImagesFolder(ref string sourceImagePath)
        {
            string destinationFolderPath = @"C:\DVLD_People_Images\";

            if (!CreateFolderIfDoesNotExist(destinationFolderPath))
            {
                return false;
            }

            string destinationImagePath = destinationFolderPath + GetReplacedFileNameGUID(sourceImagePath);

            try
            {
                File.Copy(sourceImagePath, destinationImagePath, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceImagePath = destinationImagePath;
            return true;
        }
    }

}
