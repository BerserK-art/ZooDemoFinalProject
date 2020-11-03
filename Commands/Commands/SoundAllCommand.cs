//Неймспейс должен совпадать с путём к папке
namespace Zoo.Commands
{
    //Стоило сделать класс CommandBase, чтобы избежать дублирование кода с присваением зоопарка,
    //а зоопарк сделать protected полем и proetected конструктор
    public class SoundAllCommand : ICommand
    {
        private ZooPark _zoo;

        public SoundAllCommand(ZooPark zoo)
        {
            _zoo = zoo;
        }

        public string Execute()
        {
            //лучше было воспользоваться стрелочной функцией
            return _zoo.AllSounds();
        }
    }
}
