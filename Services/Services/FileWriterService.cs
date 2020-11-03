using System.Collections.Generic;
using System.IO;
using System.Text;
//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
    public class FileWriterService : IWriterService
    {
        //название капсом недопустимо, так же поле, модифицируемое только в конструкторе может быть readonly
        private string _URL;
        //название параетра капсом недопустимо
        public FileWriterService(string URL)
        {
            _URL = URL;
        }

        public void Write(List<IAnimal> animals)
        {
            //Лучше использовать не string, а StringBuilder
            string tmp="";
            //возможно использовать LINQ
            foreach(var el in animals)
            {
                tmp += el.ToString();
            }
            //очень старый способ работы с файлами
            if (File.Exists(_URL))
            {
                File.Delete(_URL);
            }
            //большой молодец, что использовал using
            using (FileStream file = File.Create(_URL))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(tmp);
                file.Write(info, 0, info.Length);
            }
        }
    }
}
