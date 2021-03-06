﻿using System;

namespace AnimalsDemo.Animals.Bists
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

        public string MakeSound()=> "рыг";   

        public string PrintInfo()=> $"Тигр :\n" +
                $"время нахождения {FoundingTime}\n" +
                $"зона обитания {Area}\n" +
                $"размер {Height}см\n" +
                $"вес {Weight}кг\n" +
                $"цвет глаз: {EyeColor}";
        public override string ToString()=>$"Tiger,{Area},{FoundingTime},{Height},{Weight},{EyeColor}\n";

    }
}
