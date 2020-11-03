using System;
//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
    public interface IPet : IAnimal
    {
        string Name { get; }
        string Breed { get; }
        bool Vaccination { get; }
        string WoolColor { get; }
        DateTime BirthDay { get; }
        string Caress();
    }
}
