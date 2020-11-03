using System;
//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
   public interface IBist : IAnimal
    {
        string Area { get; }
        DateTime FoundingTime { get; }
    }
}
