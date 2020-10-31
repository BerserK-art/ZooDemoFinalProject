using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zoo
{
    public class FileWriterService : IWriterService
    {
        private string _URL;
        public FileWriterService(string URL)
        {
            _URL = URL;
        }

        public void Write(List<IAnimal> animals)
        {
            string tmp="";
            foreach(var el in animals)
            {
                tmp += el.ToString();
            }
            if (File.Exists(_URL))
            {
                File.Delete(_URL);
            }
            using (FileStream file = File.Create(_URL))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(tmp);
                file.Write(info, 0, info.Length);
            }
            
            
        }
    }
}
