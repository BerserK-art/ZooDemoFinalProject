using AnimalsDemo;
using Commands.ModelsBase;

namespace Commands.Commands
{
    public class SoundAllCommand : CommandBase
    {
        public SoundAllCommand(ZooPark zoo) : base(zoo)
        {
        }

        public override string Execute()=> _zoo.AllSounds();

    }
}
