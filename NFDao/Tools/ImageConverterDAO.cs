using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NFDao.Tools
{
    public static class ImageConverterDAO
    {
        public static bool IsImage(HttpPostedFile file)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" }; // Lista de extensiones permitidas.
            string fileExtension = Path.GetExtension(file.FileName).ToLower();
            return allowedExtensions.Contains(fileExtension);
        }
        public static byte[] ConvertImageToByteArray(HttpPostedFile file,string folder)
        {
            string fileName = Path.GetFileName(file.FileName);
            string filePath = Path.Combine(folder, fileName);
            file.SaveAs(filePath);

            // Leer el archivo de imagen y convertirlo en un array de bytes.

            using (Stream stream = file.InputStream)
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    return reader.ReadBytes((int)stream.Length);
                }
            }
        }
        public static string ConvertImageToURL(byte[] image)
        {
            return "data:image/jpeg;base64," + Convert.ToBase64String(image);
        }
    }
}
