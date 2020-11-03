using Core.Interfeces;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Commands
{
    //Стоило сделать класс CommandBase, чтобы избежать дублирование кода с присваением зоопарка,
    //а зоопарк сделать protected полем и proetected конструктор
    public class DeleteCommand : ICommand
    {
        private ZooPark _zoo;
        private INotifyService _notifyService;
        private IGetService _getService;
        public DeleteCommand(ZooPark zoo,INotifyService notifyService,IGetService getService)
        {
            _zoo = zoo;
            _notifyService = notifyService;
            _getService = getService;
        }

        public string Execute()
        {
            _getService.Write("введите индекс");
            int index = int.Parse(_notifyService.ReadText());
            _zoo.Delete(index);
            return "Животное удалено";
        }
    }
}
