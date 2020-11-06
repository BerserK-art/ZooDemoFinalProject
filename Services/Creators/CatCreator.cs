using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creators
{
    public class CatCreator : ICreator
    {
        public string Create()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Cat,");
            Console.Write("Введите кличку: ");
            stringBuilder.Append($"{Console.ReadLine()},");
            Console.Write("Введите пароду: ");
            stringBuilder.Append($"{Console.ReadLine()},");
            Console.Write("Привита (y/n):");
            stringBuilder.Append(Console.ReadLine() == "y" ? "True," : "False,");
            Console.Write("Введите цвет шерсти: ");
            stringBuilder.Append($"{Console.ReadLine()},");
            stringBuilder.Append(DateTime.Today.ToString());
            Console.Write("введите размер:");
            stringBuilder.Append($",{Console.ReadLine()},");
            Console.Write("введите вес:");
            stringBuilder.Append($"{Console.ReadLine()},");
            Console.Write("введите цвет глаз:");
            stringBuilder.Append($"{Console.ReadLine()},");
            Console.Write("Лысая порда? (y/n)");
            stringBuilder.Append(Console.ReadLine() == "y" ?  "False" : "True" );
            return stringBuilder.ToString();
        }
    }
}
