using Core.Interfeces;
using System;


namespace Zoo.NotifyServices
{
    public class NotifyConsole : INotifyService
    {
        public string ReadText()
        {
            return Console.ReadLine();
        }
    }
}
