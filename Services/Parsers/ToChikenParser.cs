using AnimalsDemo.Animals.Birds;
using Core.Interfeces;
using System;


namespace Services.Parsers
{
    public class ToChikenParser : IParser
    {
        public IAnimal Parse(string[] str)
        {
            if (str[0] != "Chiken" || str.Length != 5)
                throw new FormatException("Not a chiken");   
            return new Chiken(int.Parse(str[1]),double.Parse(str[2]),double.Parse(str[3]),str[4]);
        }


    }
}
