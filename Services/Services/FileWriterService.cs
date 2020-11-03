using Core.Interfeces;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zoo
{
    public class FileWriterService : IWriterService
    {
        private string _url;
        public FileWriterService(string url)
        {
            _url = url;
        }
        public void Write(List<IAnimal> animals)
        {
            StringBuilder stringBuilder = new StringBuilder();
            animals.ForEach(el => stringBuilder.Append(el.ToString()));
            if (File.Exists(_url))
            {
                File.Delete(_url);
            }
            using (FileStream file = File.Create(_url))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(stringBuilder.ToString());
                file.Write(info, 0, info.Length);
            }
        }
    }
}
