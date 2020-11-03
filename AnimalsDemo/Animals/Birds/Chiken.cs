//Неймспейс должен совпадать с путём к папке
namespace Zoo.Animals
{
    public class Chiken : Bird
    {
        public Chiken(int flyHeaight, double height, double weight, string eyeColor) 
            : base(flyHeaight, height, weight, eyeColor)
        {
        }

        public override string MakeSound()
        {
            //лучше всего использовать стрелочную функцию
            return "Куд-куда";
        }

        public override string PrintInfo()
        {
            return $"Курица :\n" +
                $"высота полёта: {FlyHeight}\n" +
                $"размер {Height}см\n" +
                $"вес {Weight}кг\n" +
                $"цвет глаз: {EyeColor}";
        }
        public override string ToString()
        {
            //лучше всего использовать стрелочную функцию
            return $"Chiken,{FlyHeight},{Height},{Weight},{EyeColor}\n";
        }
    }
}
