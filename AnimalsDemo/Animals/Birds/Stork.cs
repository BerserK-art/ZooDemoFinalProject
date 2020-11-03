//Неймспейс должен совпадать с путём к папке
namespace Zoo.Animals
{
    public  class Stork : Bird
    {
        public Stork(int flyHeaight, double height, double weight, string eyeColor) : base(flyHeaight, height, weight, eyeColor)
        {
        }

        public override string MakeSound()
        {
            //лучше всего использовать стрелочную функцию
            return "Щёлк";
        }

        public override string PrintInfo()
        {
            return $"Аист :\n" +
                $"высота полёта: {FlyHeight}\n" +
                $"размер {Height}см\n" +
                $"вес {Weight}кг\n" +
                $"цвет глаз: {EyeColor}";
        }
        public override string ToString()
        {
            //лучше всего использовать стрелочную функцию
            return $"Stork,{FlyHeight},{Height},{Weight},{EyeColor}\n";
        }
    }
}
