using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;

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
