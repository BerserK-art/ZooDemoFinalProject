using Core.Interfeces;
using System;
//Это должно быть в консольном проекте, а не в кроссплатформенном коде
namespace Services.NotifyServices
{
    public class NotifyConsole : INotifyService
    {
        public string ReadText()
        {
            return Console.ReadLine();
        }
    }
}
