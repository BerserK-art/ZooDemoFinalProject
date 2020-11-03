using Services.Fabrics;
//Неймспейс должен совпадать с путём к папке
namespace Zoo.Coomands
{
    //Стоило сделать класс CommandBase, чтобы избежать дублирование кода с присваением зоопарка, а зоопарк сделать protected полем
    public class AddAnimalCommand : ICommand
    {
        //приватные моля, именяемые только в конструкторе можно делать readonly
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
