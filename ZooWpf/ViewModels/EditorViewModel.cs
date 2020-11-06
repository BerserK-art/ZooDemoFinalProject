using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWpf.ViewModels
{
    public class EditorViewModel : BaseViewModel
    {
        private IAnimal _choosenAnimal;

        public EditorViewModel()
        {
        }

        public IAnimal ChoosenAnimal
        {
            get => _choosenAnimal;
            set
            {
                _choosenAnimal = value;
                NotifyOfPropertyChanged("ChoosenAnimal");
            }
        }

    }
}
