using AnimalsDemo;
using Core.Interfeces;

namespace Commands.ModelsBase
{
    public abstract class NotifyCommandBase : CommandBase
    {

        protected readonly INotifyService _notifyService;
        protected readonly IGetService _getService;
        protected NotifyCommandBase(ZooPark zoo, INotifyService notifyService, IGetService getService) : base(zoo)
        {
            _notifyService = notifyService;
            _getService = getService;
        }
        
        
    }
}
