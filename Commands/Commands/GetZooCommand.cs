//Неймспейс должен совпадать с путём к папке
namespace Zoo.Commands
{
    //Стоило сделать класс CommandBase, чтобы избежать дублирование кода с присваением зоопарка,
    //а зоопарк сделать protected полем и proetected конструктор
    public class GetZooCommand : ICommand
    {
        private ZooPark _zoo;
        private IReaderService _readerService;
        public GetZooCommand(ZooPark zoo,IReaderService readerService)
        {
            _readerService = readerService;
            _zoo = zoo;
        }

        public string Execute()
        {
            _zoo.ReadFromFile(_readerService);
            return "Зоопарк загружен";
        }
    }
}
