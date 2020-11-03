using AnimalsDemo.Animals.Birds;
using Core.Interfeces;

namespace Services.Fabrics
{
    public class GetStork : FabricBase
    {
        public GetStork(IGetService getService, INotifyService notifyService) : base(getService, notifyService)
        {
        }

        public override IAnimal GetAnimal()
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
        public override string ToString()=> "Аист";

    }
}
