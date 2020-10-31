using Services.Fabrics;
using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Animals;

namespace Zoo.Coomands
{
   public class AddAnimalCommand : ICommand
    {
        private ZooPark _zoo;
        private AnimalFabric _animalFabric; 
        public AddAnimalCommand(ZooPark zoo,AnimalFabric animalFabric)
        {
            _zoo = zoo;
            _animalFabric = animalFabric;
        }
        

        public string Execute()
        {          
            _zoo.Add(_animalFabric.GetIAnimal());
            return "Животное добавлено";
        }
    }
}
