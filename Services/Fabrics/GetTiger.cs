using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    public class GetTiger : IFabric
    {
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetTiger(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }

        public IAnimal GetAnimal()
        {
            _getService.Write("Введите ареал:");
            string Area = _notifyService.ReadText();
            _getService.Write("введите размер:");
            double Height = double.Parse(_notifyService.ReadText());
            _getService.Write("введите вес:");
            double Weight = double.Parse(_notifyService.ReadText());
            _getService.Write("введите цвет глаз:");
            string eyecolor = _notifyService.ReadText();
            return new Tiger(Area,DateTime.Now,Height,Weight,eyecolor);
        }
        public override string ToString()
        {
            return "Тигр";
        }
    }
}
