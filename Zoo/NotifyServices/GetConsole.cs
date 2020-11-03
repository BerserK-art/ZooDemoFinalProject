using Core.Interfeces;
using System;


namespace Zoo.NotifyServices
{
    public class GetConsole : IGetService
    {
     
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
