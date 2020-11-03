using AnimalsDemo;
using Commands.ModelsBase;

namespace Commands.Coomands
{
    public class InfoAllComand : CommandBase
    {
        public InfoAllComand(ZooPark zoo) : base(zoo)
        {
        }

        public override string Execute()=> _zoo.PrintAll();

    }
}
