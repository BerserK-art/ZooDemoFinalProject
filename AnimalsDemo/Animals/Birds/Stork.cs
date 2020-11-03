namespace AnimalsDemo.Animals.Birds
{
   public  class Stork : Bird
    {
        public Stork(int flyHeaight, double height, double weight, string eyeColor) : base(flyHeaight, height, weight, eyeColor)
        {
        }

        public override string MakeSound()=> "Щёлк";   
        public override string PrintInfo()=> $"Аист :\n" +
                $"высота полёта: {FlyHeight}\n" +
                $"размер {Height}см\n" +
                $"вес {Weight}кг\n" +
                $"цвет глаз: {EyeColor}";

        public override string ToString()=> $"Stork,{FlyHeight},{Height},{Weight},{EyeColor}\n";
        
    }
}
