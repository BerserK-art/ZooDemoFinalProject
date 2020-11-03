using AnimalsDemo.Animals.Bists;
using Core.Interfeces;
using System;


namespace Zoo.Parsers
{
    public class ToWolfParser : IParser
    {
        public IAnimal Parse(string[] str)
        {
            if (str[0] != "Wolf" || str.Length != 7)
                throw new FormatException("Not a wolf");
            return new Wolf(str[1], DateTime.Parse(str[2]), double.Parse(str[3]), double.Parse(str[4]), str[5],bool.Parse(str[6]));
        }
    }
}
