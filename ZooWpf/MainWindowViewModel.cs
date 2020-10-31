using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo;

namespace ZooWpf
{
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
