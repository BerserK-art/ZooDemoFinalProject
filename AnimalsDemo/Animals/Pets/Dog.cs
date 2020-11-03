using System;

//Неймспейс должен совпадать с путём к папке
namespace Zoo.Animals
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
        public override string ToString()
        {
            return $"Dog,{Name},{Breed},{Vaccination},{WoolColor},{BirthDay},{Height},{Weight},{EyeColor},{Training}\n";
        }

        public string Name { get; }

        public string Breed { get; }

        public bool Vaccination { get; }

        public string WoolColor { get; }

        public DateTime BirthDay { get; }

        public double Height { get; }

        public double Weight { get; }

        public string EyeColor { get; }
        public bool Training { get; private set; }

        public string Caress()
        {
            return "Машет хвостиком";
        }

        public string MakeSound()
        {
            return "Гав";
        }

        public string PrintInfo()
        {
            //лучше использовать тернарный оператор
            string a = "Тренировки нет";
            if ( Training== true)
                a = $"Тренирована";
            //лучше использовать тернарный оператор
            string b = "вакцинации нет";
            if (Vaccination == true)
                b = $"привита";

            return $"Собака {Name}:\n" +
                $"порода {Breed}\n" +
               $"день рождения: {BirthDay}\n" +
               $"{a}\n" +
               $"{b}\n" +
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
