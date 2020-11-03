using AnimalsDemo;
using Commands.ModelsBase;
using Core.Interfeces;

namespace Commands.Coomands
{
    public class SaveCommand : CommandBase
    {
        private readonly IWriterService _writerService;

        public SaveCommand(ZooPark zoo,IWriterService writerService) : base(zoo)
        {
            _writerService = writerService;
        }

        public override string Execute()
        {
            _zoo.SaveToFile(_writerService);
            return "Сохранено";
        }
    }
}
