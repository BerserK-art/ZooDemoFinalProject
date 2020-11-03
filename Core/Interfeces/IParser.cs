//Неймспейс должен совпадать с путём к папке
namespace Zoo.Interfeces
{
    public interface IParser
    {
        IAnimal Parse(string[] str);
    }
}
