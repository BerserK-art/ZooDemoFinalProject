using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    public class GetWolf : IFabric
    {
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetWolf(IGetService getService, INotifyService notifyService)
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
            _getService.Write("Вожак стаи? (y/n)");
            string Alpha = _notifyService.ReadText();
            bool AlphaBool = false;
            if (Alpha == "y")
                AlphaBool = true;
            return new Wolf(Area, DateTime.Now, Height, Weight, eyecolor,AlphaBool);
        }
        public override string ToString()
        {
            return "Волк";
        }
    }
}
