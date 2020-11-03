using System.Collections.Generic;
//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
    public interface IReaderService
    {
        List<IAnimal> Read();
    }
}
