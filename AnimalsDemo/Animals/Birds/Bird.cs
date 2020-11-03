using Core.Interfeces;

namespace AnimalsDemo.Animals.Birds
{
    public abstract class Bird : IAnimal
    {
        protected Bird(int flyHeaight, double height, double weight, string eyeColor)
        {
            Height = height;
            FlyHeight = flyHeaight;
            Weight = weight;
            EyeColor = eyeColor;
        }
        protected int FlyHeight;
        public  double Height { get; }
        public  double Weight { get; }
        public  string EyeColor { get; }

        public abstract string MakeSound();
        public abstract string PrintInfo();
        public string Fly() => $"Я лечу на {FlyHeight} метрах";
        

    }
}
