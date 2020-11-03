﻿using System;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Animals
{
    public class Wolf : IBist
    {
        public Wolf(string area, DateTime founding, double height, double weight, string eyecolor, bool alpha)
        {
            Area = area;
            FoundingTime = founding;
            Height = height;
            Weight = weight;
            EyeColor = eyecolor;
            Alpha = alpha;
        }
        public string Area { get; }

        public DateTime FoundingTime { get; }

        public double Height { get; }

        public double Weight { get; }

        public string EyeColor { get; }
        public bool Alpha{get; }

        public string MakeSound()
        {
            //лучше всего использовать стрелочную функцию
            return "ауф";
        }

        public string PrintInfo()
        {
            string a = "";
            //лучше тут использовать тернаный оператор
                if(Alpha==true)
                    a = "\nвожак стаи";
            return $"Волк :\n" +
               $"время нахождения {FoundingTime}\n" +
               $"зона обитания {Area}\n" +
               $"размер {Height}см\n" +
               $"вес {Weight}кг\n" +
               $"цвет глаз: {EyeColor}"+
               a;
        }
        public override string ToString()
        {
            return $"Wolf,{Area},{FoundingTime},{Height},{Weight},{EyeColor},{Alpha}\n";
        }
    }
}
