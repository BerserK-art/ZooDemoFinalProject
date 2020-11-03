using AnimalsDemo.Animals.Pets;
using Core.Interfeces;
using System;


namespace Services.Fabrics
{
    public class GetCat : FabricBase
    {
        public GetCat(IGetService getService, INotifyService notifyService) : base(getService, notifyService)
        {
        }

        public override IAnimal GetAnimal()
        {
            _getService.Write("Введите кличку");
            string Name = _notifyService.ReadText();
            _getService.Write("Введите пароду");
            string Breed=_notifyService.ReadText();
            _getService.Write("Привита (y/n)");
            string vac = _notifyService.ReadText();
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
            return new Cat(Name,Breed, (vac == "y" ? true : false), WoolColor,DateTime.Today,Height,Weight,eyecolor,(wool == "y" ? true : false));
        }
        public override string ToString()=> "Кот";

    }
}
