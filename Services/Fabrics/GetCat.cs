using Core.Interfeces;
using System;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    public class GetCat : IFabric
    {
        //здесь бы не помешал базовый класс AbstractFacroty для избежания дублирования кода этих полей
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetCat(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }

        public IAnimal GetAnimal()
        {
            //по идее это всё можно вычитывать в твоих парсерах или их для этого использовать
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
        //лучше всего использовать стрелочную функцию
        public override string ToString()
        {
            return "Кот";
        }
    }
}
