using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfeces
{
    public interface IParser
    {
        IAnimal Parse(string[] str);
    }
}
