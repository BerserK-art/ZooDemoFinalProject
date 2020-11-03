using Core.Interfeces;
using System;


namespace AnimalsDemo.Animals.Bists
{
   public interface IBist : IAnimal
    {
        string Area { get; }
        DateTime FoundingTime { get; }
    }
}
