using AnimalsDemo;
using Commands.ModelsBase;
using Core.Interfeces;


namespace Commands.Coomands
{
    public class InfoCommand : NotifyCommandBase
    {
        public InfoCommand(ZooPark zoo, INotifyService notifyService, IGetService getService) : base(zoo, notifyService, getService)
        {
        }

        public override string Execute()
        {
            _getService.Write("введите индекс");
            int index = int.Parse(_notifyService.ReadText());
            return _zoo.InfoAbout(index);
        }
    }
}
