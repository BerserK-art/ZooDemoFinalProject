using System;
using System.Collections.Generic;
using Zoo.Animals;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Srvices
{
    public class TestReader : IReaderService
    {
       

        public List<IAnimal> Read()
        {
            //лучше всего использовать стрелочную функцию
            List<IAnimal> animals = new List<IAnimal>()
            {
                new Chiken(3,40,5,"Black"),
                new Stork(25,120,15,"Black"),
                new Tiger("Amur",DateTime.Today,200,100,"Red"),
                new Wolf("Forest",DateTime.Today,140,34,"White",false),
                new Dog("Sharik","Ovcharka",true,"Brown",DateTime.Today,80,26,"Red",false),
                new Cat("Murka","Siam",true,"White",DateTime.Today,56,6,"Green",true)
            };
            return animals;
        }
    }
}
