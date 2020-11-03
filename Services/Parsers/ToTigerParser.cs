using System;
using Zoo.Animals;
using Zoo.Interfeces;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Parsers
{
    public class ToTigerParser : IParser
    {
        public IAnimal Parse(string[] str)
        {
            if (str[0] != "Tiger" || str.Length != 6)
                throw new FormatException("Not a tiger");
            return new Tiger(str[1],DateTime.Parse(str[2]),double.Parse(str[3]),double.Parse(str[4]),str[5]);
        }
    }
}
