using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Commands
{
    public class InfoAllComand : ICommand
    {
        private ZooPark _zoo;
        public InfoAllComand(ZooPark zoo)
        {
            _zoo = zoo;
        }

        public string Execute()
        {
            return _zoo.PrintAll();
        }
    }
}
