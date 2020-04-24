using System.IO;

namespace SandBoxRestApiUdemy.Business.Implementattions
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFile()
        {
            string path = Directory.GetCurrentDirectory();

            var fullPath = path + "\\Other\\SEGURO MOZAO 2 – Outlook.pdf";


            return File.ReadAllBytes(fullPath);
        }
    }
}
