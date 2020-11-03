using Core.Interfeces;
using System;
using System.Collections.Generic;
using Zoo;

namespace Services.Fabrics
{
    //фабрики лучше всего делать одиночками
    public class AnimalFabric
    {
        //приватные поля, изменяющиеся только в конструкторе, лучше всего сделать readonly
        private IGetService _getService;
        private INotifyService _notifyService;
        //лучше всего использорвать IDictionary
        private  Dictionary<string, IFabric> _dict;
        //лучше всего в параметрах конструктора использовать только интерфейсы или приметивные типы
        public AnimalFabric(Dictionary<string, IFabric> dict,IGetService getService,INotifyService notifyService)
        {
            _dict = dict;
            _getService = getService;
            _notifyService = notifyService;
        }
        // это не зона ответственности фабрики, а зона ответственности меню или какого-нибудь Creatorа
        public  void Menu()
        {
            foreach(var el in _dict)
            {
                _getService.Write($"{el.Key} - {el.Value.ToString()}");
            }
        }
        public IAnimal GetIAnimal()
        {
            //не вижу смысла вызова тут этого метода
            Menu();
            string str = _notifyService.ReadText();
            if (!_dict.ContainsKey(str))
                throw new InvalidOperationException("there is no this animal");
            return _dict[str].GetAnimal();
        }
    }
}
