//Неймспейс должен совпадать с путём к папке
namespace Zoo.Commands
{
    //Стоило сделать класс CommandBase, чтобы избежать дублирование кода с присваением зоопарка,
    //а зоопарк сделать protected полем и proetected конструктор
    public class InfoAllComand : ICommand
    {
        private ZooPark _zoo;
        public InfoAllComand(ZooPark zoo)
        {
            _zoo = zoo;
        }

        public string Execute()
        {
            //лучше всего использовать стрелочную функцию
            return _zoo.PrintAll();
        }
    }
}
