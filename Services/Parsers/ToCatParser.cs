﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Animals;
using Zoo.Interfeces;

namespace Zoo.Parsers
{
    public class ToCatParser : IParser
    {
        public IAnimal Parse(string[] str)
        {
            if (str[0] != "Cat" || str.Length != 10)
                throw new FormatException("Not a cat");
            return new Cat(str[1],str[2],bool.Parse(str[3]),str[4],DateTime.Parse(str[5]),double.Parse(str[6]),double.Parse(str[7]),str[8],bool.Parse(str[9]));
        }
    }
}
