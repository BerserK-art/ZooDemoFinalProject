//Неймспейс должен совпадать с путём к папке
namespace Zoo
{
    public interface IAnimal
    {
        double Height { get; }
        double Weight{ get; }
        string EyeColor { get; }
        string MakeSound();
        string PrintInfo();
        //ToString не имеет смысла писать в интерфейсах, так как интерфейсы тоже наследники object где есть этот метод
        string ToString();
    }
}
