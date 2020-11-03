using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Fabrics
{
    public class AnimalFabric
    {
        private IGetService _getService;
        private INotifyService _notifyService;
        private  IDictionary<string, IFabric> _dict;
        public AnimalFabric(IDictionary<string, IFabric> dict,IGetService getService,INotifyService notifyService)
        {
            _dict = dict;
            _getService = getService;
            _notifyService = notifyService;
        }
        public IAnimal GetIAnimal()
        {
            _getService.Write("Выберите животное:");
            _dict.ToList().ForEach(el => _getService.Write($"{el.Key} - {el.Value.ToString()}"));
            string str = _notifyService.ReadText();
            if (!_dict.ContainsKey(str))
                throw new InvalidOperationException("there is no this animal");
            return _dict[str].GetAnimal();
        }
    }
}
