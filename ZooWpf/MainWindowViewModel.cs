using System.ComponentModel;
using Zoo;

namespace ZooWpf
{
    //надо доделать логику добавления, получения, редактирования и удаления животных
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private IAnimal[] animals;

        public MainWindowViewModel()
        {
            ZooPark zoo = new ZooPark();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
