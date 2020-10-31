using System.Collections.Generic;

namespace Zoo
{
    public class FileReaderService : IReaderService
    {
        private string _URL;
        private readonly ToAnimalParser _animalParser;
        public FileReaderService(string URL, ToAnimalParser animalParser)
        {
            _URL = URL;
            _animalParser = animalParser;
        }

        public List<IAnimal> Read()
        {
            string[] lines = System.IO.File.ReadAllLines(_URL);
            List<IAnimal> animals = new List<IAnimal>();
            foreach(var el in lines)
            {
                animals.Add(_animalParser.ToAnimal(el));
            }
            return animals;
        }
    }
}
