using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;

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
