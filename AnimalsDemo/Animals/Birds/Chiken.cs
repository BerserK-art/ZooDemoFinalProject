
namespace AnimalsDemo.Animals.Birds
{
    public class Chiken : Bird
    {
        public Chiken(int flyHeaight, double height, double weight, string eyeColor) 
            : base(flyHeaight, height, weight, eyeColor)
        {
        }

        public override string MakeSound() => "Куд-куда";
        public override string PrintInfo()=>$"Курица :\n" +
                $"высота полёта: {FlyHeight}\n" +
                $"размер {Height}см\n" +
                $"вес {Weight}кг\n" +
                $"цвет глаз: {EyeColor}";
        
        public override string ToString()=> $"Chiken,{FlyHeight},{Height},{Weight},{EyeColor}\n";
       
    }
}
