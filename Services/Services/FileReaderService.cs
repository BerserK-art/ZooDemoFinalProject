using Core.Interfeces;
using Services.Parsers;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
    public class FileReaderService : IReaderService
    {
        private string _url;
        private readonly ToAnimalParser _animalParser;
        public FileReaderService(string url, ToAnimalParser animalParser)
        {
            _url = url;
            _animalParser = animalParser;
        }

        public List<IAnimal> Read()
        {
            string[] lines = System.IO.File.ReadAllLines(_url);
            List<IAnimal> animals = new List<IAnimal>();
            lines.ToList().ForEach(el => animals.Add(_animalParser.ToAnimal(el)));
            return animals;
        }
    }
}
