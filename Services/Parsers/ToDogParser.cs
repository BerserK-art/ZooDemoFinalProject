using System;
using Zoo.Animals;
using Zoo.Interfeces;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Parsers
{
    public  class ToDogParser : IParser
    {
        public IAnimal Parse(string[] str)
        {
            if (str[0] != "Dog" || str.Length != 10)
                throw new FormatException("Not a Dog");
            return new Dog(str[1], str[2], bool.Parse(str[3]), str[4], DateTime.Parse(str[5]), double.Parse(str[6]), double.Parse(str[7]), str[8], bool.Parse(str[9]));
        }
    }
}
