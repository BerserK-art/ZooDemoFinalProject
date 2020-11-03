using AnimalsDemo;
using Commands.ModelsBase;
using Services.Fabrics;

namespace Commands.Coomands
{
    public class AddAnimalCommand : CommandBase
    {
        private readonly AnimalFabric _animalFabric; 
        public AddAnimalCommand(ZooPark zoo,AnimalFabric animalFabric) : base(zoo)
        {
            _animalFabric = animalFabric;
        }
        public override string Execute()
        {          
            _zoo.Add(_animalFabric.GetIAnimal());
            return "Животное добавлено";
        }
    }
}
