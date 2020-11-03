using AnimalsDemo;
using Core.Interfeces;

namespace Commands.ModelsBase
{
    public abstract class CommandBase : ICommand
    {
        protected readonly ZooPark _zoo;
        protected CommandBase(ZooPark zoo)
        {
            _zoo = zoo;
        }
        public abstract string Execute();
    }
}
