using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public class Cat : IPet
    {
        public Cat(string name, string breed, bool vaccination, string woolColor,
            DateTime birthDay, double height, double weight, string eyeColor, bool wool)
        {
            Name = name;
            Breed = breed;
            Vaccination = vaccination;
            WoolColor = woolColor;
            BirthDay = birthDay;
            Height = height;
            Weight = weight;
            EyeColor = eyeColor;
            Wool = wool;
        }
        public override string ToString()
        {
            return $"Cat,{Name},{Breed},{Vaccination},{WoolColor},{BirthDay},{Height},{Weight},{EyeColor},{Wool}\n";
        }

        public string Name { get;  }

        public string Breed { get;  }

        public bool Vaccination { get; }

        public string WoolColor { get; }

        public DateTime BirthDay { get; }

        public double Height { get;  }

        public double Weight { get; }

        public string EyeColor { get;  }
        public bool Wool { get; }

        public string Caress()
        {
            return "мурлычет";
        }

        public string MakeSound()
        {
            return "мяу";
        }

        public string PrintInfo()
        {
            string a = "Шерсти нет";
            if (Wool == true)
                a = $"Цвет шерсти: {WoolColor}";

            string b = "вакцинации нет";
            if (Vaccination == true)
                b = $"привита";

            return $"Кошка {Name}:\n" +
                $"порода {Breed}\n" +
               $"день рождения: {BirthDay}\n" +
               $"{a}\n" +
               $"{b}\n" +
               $"размер {Height}см\n" +
               $"вес {Weight}кг\n" +
               $"цвет глаз: {EyeColor}";
        }
    }
}
