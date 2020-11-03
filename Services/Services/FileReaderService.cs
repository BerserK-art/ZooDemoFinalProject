using System.Collections.Generic;
using System.IO;

//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
    public class FileReaderService : IReaderService
    {
        //поле, модифицируемое только в конструкторе может быть readonly, так же не называем это капсом
        private string _URL;
        private readonly ToAnimalParser _animalParser;
        //названия капсом недопустимы
        public FileReaderService(string URL, ToAnimalParser animalParser)
        {
            _URL = URL;
            _animalParser = animalParser;
        }

        public List<IAnimal> Read()
        {
            //очень старый способ чтения из файла, советую не пользоваться такими способами
            string[] lines = File.ReadAllLines(_URL);
            List<IAnimal> animals = new List<IAnimal>();
            //возможно было использовать Linq вместо этого foreach
            foreach(var el in lines)
            {
                animals.Add(_animalParser.ToAnimal(el));
            }
            return animals;
        }
    }
}
