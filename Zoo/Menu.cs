using System;
using System.Collections.Generic;

namespace Zoo
{
    class Menu
    {
        private readonly IDictionary<string, ICommand> _commands;
        public Menu(IDictionary<string, ICommand> commands)
        {
            _commands = commands;
        }
        public bool IsThere(string command)
        {
            //тут нужно импользовать просто стрелочную функцию
            if (_commands.ContainsKey(command))
            {
                return true;
            }
            return false;
        }
        public string Choose(string command)
        {
            if (!_commands.ContainsKey(command))
                throw new InvalidOperationException("there is no this command");
            return _commands[command].Execute();
        }
    }
}
