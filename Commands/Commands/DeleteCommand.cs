using AnimalsDemo;
using Commands.ModelsBase;
using Core.Interfeces;

namespace Commands.Coomands
{
    public class DeleteCommand : NotifyCommandBase
    {
        public DeleteCommand(ZooPark zoo, INotifyService notifyService, IGetService getService) : base(zoo, notifyService, getService)
        {
        }

        public override string Execute()
        {
            _getService.Write("введите индекс");
            int index = int.Parse(_notifyService.ReadText());
            _zoo.Delete(index);
            return "Животное удалено";
        }
    }
}
