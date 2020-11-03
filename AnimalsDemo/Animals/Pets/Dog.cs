using System;
using System.Text;

namespace AnimalsDemo.Animals.Pets
{
    public class Dog : IPet
    {
        public Dog(string name, string breed , bool vaccination ,  string woolColor, 
            DateTime birthDay , double height , double weight , string eyeColor,bool training )
        {
            Name = name;
            Breed = breed;
            Vaccination = vaccination;
            WoolColor = woolColor;
            BirthDay = birthDay;
            Height = height;
            Weight = weight;
            EyeColor = eyeColor;
            Training = training;
        }
        public override string ToString()=> $"Dog,{Name},{Breed},{Vaccination},{WoolColor},{BirthDay},{Height},{Weight},{EyeColor},{Training}\n";

        public string Name { get; }

        public string Breed { get; }

        public bool Vaccination { get; }

        public string WoolColor { get; }

        public DateTime BirthDay { get; }

        public double Height { get; }

        public double Weight { get; }

        public string EyeColor { get; }
        public bool Training { get; private set; }

        public string Caress()=> "Машет хвостиком";

        public string MakeSound()=>"Гав";


        public string PrintInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Training== true ? "Тренирована\n" : "Тренировки нет\n");
            stringBuilder.Append(Vaccination == true ? "привита\n" : "вакцинации нет\n");
            return $"Собака {Name}:\n" +
                $"порода {Breed}\n" +
               $"день рождения: {BirthDay}\n" +
               stringBuilder.ToString() +
               $"размер {Height}см\n" +
               $"вес {Weight}кг\n" +
               $"цвет глаз: {EyeColor}";
        }
        public string DogTraining()
        {
            Training = true;
            return "Собака выучила новый трюки";
        }
    }
}
