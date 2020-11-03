using Core.Interfeces;
using System;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    public class GetTiger : IFabric
    {
        //здесь бы не помешал базовый класс AbstractFacroty для избежания дублирования кода этих полей
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetTiger(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }
        //лучше всё это вычитывать в парсерах или другом месте
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
            //лучше всего использовать стрелочную функцию
            return "Тигр";
        }
    }
}
