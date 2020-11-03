using Core.Interfeces;
using System;

//Это должно быть в консольном проекте, а не в кроссплатформенном коде
namespace Services.NotifyServices
{
    public class GetConsole : IGetService
    {
     
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
