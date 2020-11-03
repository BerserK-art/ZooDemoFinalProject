using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo;
using Zoo.Animals;

namespace Services.Fabrics
{
    public class GetDog : IFabric
    {
        //здесь бы не помешал базовый класс AbstractFacroty для избежания дублирования кода этих полей
        private IGetService _getService;
        private INotifyService _notifyService;
        public GetDog(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }

        public IAnimal GetAnimal()
        {
            //это всё лучше вычитывать в парсерах или другом месте
            _getService.Write("Введите кличку");
            string Name = _notifyService.ReadText();
            _getService.Write("Введите пароду");
            string Breed = _notifyService.ReadText();
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
            _getService.Write("Есть дрессировка? (y/n)");
            string Training = _notifyService.ReadText();
            bool TrainingBool = false;
            if (Training == "y")
                TrainingBool = true;
            return new Dog(Name, Breed, vacBool, WoolColor, DateTime.Today, Height, Weight, eyecolor, TrainingBool);
        }
        public override string ToString()
        {
            //лучше всего использовать стрелочную функцию
            return "Собака";
        }
    }
}
