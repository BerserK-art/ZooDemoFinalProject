using Core.Interfeces;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Commands
{
    public class InfoCommand : ICommand
    {
        //Стоило сделать класс CommandBase, чтобы избежать дублирование кода с присваением зоопарка,
        //а зоопарк сделать protected полем и proetected конструктор, так же стоило сделать базовый класс NotifyCommandBase для того, чтобы не дублировать
        //код передачи InfotifyService и IGetService
        private ZooPark _zoo;
        private INotifyService _notifyService;
        private IGetService _getService;
        public InfoCommand(ZooPark zoo,INotifyService notifyService, IGetService getService)
        {
            _zoo = zoo;
            _notifyService = notifyService;
            _getService = getService;
        }

        public string Execute()
        {
            _getService.Write("введите индекс");
            int index = int.Parse(_notifyService.ReadText());
            return _zoo.InfoAbout(index);
        }
    }
}
