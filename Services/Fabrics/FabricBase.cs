using Core.Interfeces;

namespace Services.Fabrics
{
  public abstract  class FabricBase : IFabric
    {
        protected readonly IGetService _getService;
        protected readonly INotifyService _notifyService;

       protected FabricBase(IGetService getService, INotifyService notifyService)
        {
            _getService = getService;
            _notifyService = notifyService;
        }

        public abstract IAnimal GetAnimal();
    }
}
