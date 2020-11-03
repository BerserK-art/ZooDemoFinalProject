using AnimalsDemo.Animals.Bists;
using Core.Interfeces;
using System;


namespace Services.Fabrics
{
    public class GetTiger : FabricBase
    {
        public GetTiger(IGetService getService, INotifyService notifyService) : base(getService, notifyService)
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
            return new Tiger(Area,DateTime.Now,Height,Weight,eyecolor);
        }
        public override string ToString()=> "Тигр";
    }
}
