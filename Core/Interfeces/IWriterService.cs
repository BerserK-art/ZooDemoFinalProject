using System.Collections.Generic;
//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
    public interface IWriterService
    {
        void Write(List<IAnimal> animals);
    }
}
