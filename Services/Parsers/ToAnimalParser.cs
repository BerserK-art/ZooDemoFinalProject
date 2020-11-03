using System;
using System.Collections.Generic;
using Zoo.Interfeces;
//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
    public class ToAnimalParser
    {
        private readonly Dictionary<string, IParser> _dict;
        public ToAnimalParser(Dictionary<string, IParser > dict)
        {
            _dict = dict;
        }
        public  IAnimal ToAnimal(string str)
        {
            string[] first = str.Split(',');
            if (!_dict.ContainsKey(first[0]))
                throw new InvalidOperationException("there is no this animal");
            return _dict[first[0]].Parse(first);
        }
    }
}
