using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    public class GetCat : IFabric
    {
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetCat(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }

        public IAnimal GetAnimal()
        {
            _getService.Write("Введите кличку");
            string Name = _notifyService.ReadText();
            _getService.Write("Введите пароду");
            string Breed=_notifyService.ReadText();
            _getService.Write("Привита (y/n)");
            string vac = _notifyService.ReadText();
            bool vacBool = false;
            if (vac == "y")
                vacBool = true;
            _getService.Write("Введите цвет шерсти");
            string WoolColor = _notifyService.ReadText();
            _getService.Write("введите размер:");
            double Height = double.Parse(_notifyService.ReadText());
            _getService.Write("введите вес:");
            double Weight = double.Parse(_notifyService.ReadText());
            _getService.Write("введите цвет глаз:");
            string eyecolor = _notifyService.ReadText();
            _getService.Write("Лысая порда? (y/n)");
            string wool = _notifyService.ReadText();
            bool WoolBool = true;
            if (wool == "y")
                WoolBool = false;
            return new Cat(Name,Breed,vacBool,WoolColor,DateTime.Today,Height,Weight,eyecolor,WoolBool);
        }
        public override string ToString()
        {
            return "Кот";
        }
    }
}
