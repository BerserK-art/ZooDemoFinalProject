using System;
//Неймспейс должен совпадать с путём к папке
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
            //лучше использовать стрелочную функцию
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
            //лучше использовать стрелочную функцию
            return "мурлычет";
        }

        public string MakeSound()
        {
            //лучше использовать стрелочную функцию
            return "мяу";
        }

        public string PrintInfo()
        {
            string a = "Шерсти нет";
            //лучше использовать тернарный оператор
            if (Wool == true)
                a = $"Цвет шерсти: {WoolColor}";

            string b = "вакцинации нет";
            //лучше использовать тернарный оператор
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
