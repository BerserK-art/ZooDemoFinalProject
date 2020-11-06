using Core.Interfeces;
using Services.Parsers;
using Services.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using ZooWpf.Views;

namespace ZooWpf.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private List<IAnimal> _animals;
        public List<IAnimal> Animals
        {
            get => _animals;
            set
            {
                _animals = value;
                NotifyOfPropertyChanged("Animals");
            }
        }
        private IAnimal _selectedAnimal;
        public IAnimal SelectedAnimal
        {
            get => _selectedAnimal;
            set
            {
                _selectedAnimal = value;
                NotifyOfPropertyChanged("SelectedAnimal");
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
        public ActionCommand Sound => new ActionCommand(SoundCommand);
        public ActionCommand Delete => new ActionCommand(DeleteCommand);
        public ActionCommand Add => new ActionCommand(AddCommand);

        public ActionCommand EditCommand => new ActionCommand(Edit);
        public void AddCommand()
        {
            
        }
        public void DeleteCommand()
        {

            Animals.Remove(SelectedAnimal);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        public void SoundCommand()
        {
            MessageBox.Show(SelectedAnimal.MakeSound());
        }
        public void Edit()
        {
            EditorView view = new EditorView()
            {
                DataContext = new EditorViewModel()
                {
                    ChoosenAnimal = SelectedAnimal
                }
            };
            view.ShowDialog();

        }

    }
}
