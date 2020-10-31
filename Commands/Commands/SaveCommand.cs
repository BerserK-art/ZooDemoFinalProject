using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Commands
{
    public class SaveCommand : ICommand
    {
        private IWriterService _writerService;
        private ZooPark _zoo;

        public SaveCommand(ZooPark zoo,IWriterService writerService)
        {
            _zoo = zoo;
            _writerService = writerService;
        }

        public string Execute()
        {
            _zoo.SaveToFile(_writerService);
            return "Сохранено";
        }
    }
}
