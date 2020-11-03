using AnimalsDemo.Animals.Bists;
using Core.Interfeces;
using System;


namespace Services.Fabrics
{
    public class GetWolf : FabricBase
    {
        public GetWolf(IGetService getService, INotifyService notifyService) : base(getService, notifyService)
        {
        }

        public override IAnimal GetAnimal()
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
            return new Wolf(Area, DateTime.Now, Height, Weight, eyecolor, (Alpha == "y" ? true : false));
        }
        public override string ToString()=> "Волк";
    }
}
