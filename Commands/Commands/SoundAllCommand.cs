using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Commands
{
    public class SoundAllCommand : ICommand
    {
        private ZooPark _zoo;

        public SoundAllCommand(ZooPark zoo)
        {
            _zoo = zoo;
        }

        public string Execute()
        {
            return _zoo.AllSounds();
        }
    }
}
