//Неймспейс должен совпадать с путём к папке
namespace Zoo.Animals
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
        public string Fly()
        {
            //лучше всего использовать стрелочную функцию
            return $"Я лечу на {FlyHeight} метрах";
        }

    }
}
