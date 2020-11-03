using System;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Animals
{
    public class Tiger : IBist
    {
        public Tiger(string area, DateTime founding,double height, double weight, string eyecolor)
        {
            Area = area;
            FoundingTime = founding;
            Height = height;
            Weight = weight;
            EyeColor = eyecolor;
        }

        public string Area { get; }

        public DateTime FoundingTime { get; }

        public double Height { get; }

        public double Weight { get; }

        public string EyeColor { get; }

        public string MakeSound()
        {
            //лучше всего использовать стрелочную функцию
            return "рыг";   
        }

        public string PrintInfo()
        {
            return $"Тигр :\n" +
                $"время нахождения {FoundingTime}\n" +
                $"зона обитания {Area}\n" +
                $"размер {Height}см\n" +
                $"вес {Weight}кг\n" +
                $"цвет глаз: {EyeColor}";
        }
        public override string ToString()
        {
            //лучше всего использовать стрелочную функцию
            return $"Tiger,{Area},{FoundingTime},{Height},{Weight},{EyeColor}\n";
        }
    }
}
