using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    
    public class GetChiken : IFabric
    {
        //здесь бы не помешал базовый класс AbstractFacroty для избежания дублирования кода этих полей
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetChiken(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }

        public IAnimal GetAnimal()
        {
            //это всё лучше вычитывать в парсерах
            _getService.Write("введите высоту полёта:");
            int flyHeight = int.Parse(_notifyService.ReadText());
            _getService.Write("введите размер:");
            double Height = double.Parse(_notifyService.ReadText());
            _getService.Write("введите вес:");
            double Weight = double.Parse(_notifyService.ReadText());
            _getService.Write("введите цвет глаз:");
            string eyecolor = _notifyService.ReadText();
            return new Chiken(flyHeight,Height,Weight,eyecolor);
        }
        //лучше всего использовать стрелочную функцию
        public override string ToString()
        {
            return "Курица";
        }
    }
}
