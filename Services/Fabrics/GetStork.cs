using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    public class GetStork : IFabric
    {
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetStork(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }

        public IAnimal GetAnimal()
        {
            _getService.Write("введите высоту полёта:");
            int flyHeight = int.Parse(_notifyService.ReadText());
            _getService.Write("введите размер:");
            double Height = double.Parse(_notifyService.ReadText());
            _getService.Write("введите вес:");
            double Weight = double.Parse(_notifyService.ReadText());
            _getService.Write("введите цвет глаз:");
            string eyecolor = _notifyService.ReadText();
            return new Stork(flyHeight, Height, Weight, eyecolor);
        }
        public override string ToString()
        {
            return "Аист";
        }
    }
}
