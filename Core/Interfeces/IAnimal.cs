namespace Zoo
{
    public interface IAnimal
    {
        double Height { get; }
        double Weight{ get; }
        string EyeColor { get; }
        string MakeSound();
        string PrintInfo();
        string ToString();
    }
}
