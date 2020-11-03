using AnimalsDemo;
using Commands.ModelsBase;
using Core.Interfeces;

namespace Commands.Coomands
{
    public class GetZooCommand : CommandBase
    {
        private readonly IReaderService _readerService;
        public GetZooCommand(ZooPark zoo,IReaderService readerService) : base(zoo)
        {
            _readerService = readerService;
        }

        public override string Execute()
        {
            _zoo.ReadFromFile(_readerService);
            return "Зоопарк загружен";
        }
    }
}
