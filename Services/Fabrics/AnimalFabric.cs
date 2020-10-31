using Core.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo;

namespace Services.Fabrics
{
    public class AnimalFabric
    {
        private IGetService _getService;
        private INotifyService _notifyService;
        private  Dictionary<string, IFabric> _dict;
        public AnimalFabric(Dictionary<string, IFabric> dict,IGetService getService,INotifyService notifyService)
        {
            _dict = dict;
            _getService = getService;
            _notifyService = notifyService;
        }
        public  void Menu()
        {
            foreach(var el in _dict)
            {
                _getService.Write($"{el.Key} - {el.Value.ToString()}");
            }
        }
        public IAnimal GetIAnimal()
        {
            Menu();
            string str = _notifyService.ReadText();
            if (!_dict.ContainsKey(str))
                throw new InvalidOperationException("there is no this animal");
            return _dict[str].GetAnimal();
        }
    }
}
