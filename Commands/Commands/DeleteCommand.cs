using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Commands
{
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
