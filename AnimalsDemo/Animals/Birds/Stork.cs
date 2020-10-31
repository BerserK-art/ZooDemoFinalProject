using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
   public  class Stork : Bird
    {
        public Stork(int flyHeaight, double height, double weight, string eyeColor) : base(flyHeaight, height, weight, eyeColor)
        {
        }

        public override string MakeSound()
        {
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
            return $"Stork,{FlyHeight},{Height},{Weight},{EyeColor}\n";
        }
    }
}
