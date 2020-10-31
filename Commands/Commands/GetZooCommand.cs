using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Commands
{
    public class GetZooCommand : ICommand
    {
        private ZooPark _zoo;
        private IReaderService _readerService;
        public GetZooCommand(ZooPark zoo,IReaderService readerService)
        {
            _readerService = readerService;
            _zoo = zoo;
        }

        public string Execute()
        {
            _zoo.ReadFromFile(_readerService);
            return "Зоопарк загружен";
        }
    }
}
