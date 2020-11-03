using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo;
using Zoo.Interfeces;
using Zoo.Parsers;

namespace ZooWpf
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<IAnimal> _animals;
        public List<IAnimal> Animals
        {
            get => _animals;
            set
            {
                _animals = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Animals"));
            }
        }

        public MainWindowViewModel()
        {
            string url = @"ZooInfo.txt";
            Dictionary<string, IParser> dict = new Dictionary<string, IParser>();
            dict.Add("Chiken", new ToChikenParser());
            dict.Add("Stork", new ToStorkParser());
            dict.Add("Wolf", new ToWolfParser());
            dict.Add("Tiger", new ToTigerParser());
            dict.Add("Cat", new ToCatParser());
            dict.Add("Dog", new ToDogParser());
            ToAnimalParser toAnimalParser = new ToAnimalParser(dict);
            IReaderService readerService = new FileReaderService(url,toAnimalParser);
            _animals = readerService.Read();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
