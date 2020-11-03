//Неймспейс должен совпадать с путём к папке
namespace Zoo.Commands
{
    //Стоило сделать класс CommandBase, чтобы избежать дублирование кода с присваением зоопарка,
    //а зоопарк сделать protected полем и proetected конструктор
    public class SaveCommand : ICommand
    {
        private IWriterService _writerService;
        private ZooPark _zoo;
        public SaveCommand(ZooPark zoo,IWriterService writerService)
        {
            _zoo = zoo;
            _writerService = writerService;
        }

        public string Execute()
        {
            _zoo.SaveToFile(_writerService);
            return "Сохранено";
        }
    }
}
