using System;
using System.Text;

namespace AnimalsDemo.Animals.Pets
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
        public override string ToString()=> $"Cat,{Name},{Breed},{Vaccination},{WoolColor},{BirthDay},{Height},{Weight},{EyeColor},{Wool}\n";


        public string Name { get;  }

        public string Breed { get;  }

        public bool Vaccination { get; }

        public string WoolColor { get; }

        public DateTime BirthDay { get; }

        public double Height { get;  }

        public double Weight { get; }

        public string EyeColor { get;  }
        public bool Wool { get; }

        public string Caress()=> "мурлычет";


        public string MakeSound()=>"мяу";


        public string PrintInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Wool==true ?  $"Цвет шерсти: {WoolColor}\n" : "Шерсти нет\n");
            stringBuilder.Append(Vaccination == true ? "привита\n" : "вакцинации нет\n");


            return $"Кошка {Name}:\n" +
                $"порода {Breed}\n" +
               $"день рождения: {BirthDay}\n" +
               stringBuilder.ToString() +
               $"размер {Height}см\n" +
               $"вес {Weight}кг\n" +
               $"цвет глаз: {EyeColor}";
        }
    }
}
