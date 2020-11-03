using System;
using Zoo.Animals;
using Zoo.Interfeces;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Parsers
{
    public class ToStorkParser : IParser
    {
        public IAnimal Parse(string[] str)
        {
            if (str[0] != "Stork" || str.Length != 5)
                throw new FormatException("Not a stork");
            return new Stork(int.Parse(str[1]), double.Parse(str[2]), double.Parse(str[3]), str[4]);
        }
    }
}
