using AnimalsDemo.Animals.Pets;
using Core.Interfeces;
using Services.Creators;
using Services.Parsers;
using System;


namespace Services.Fabrics
{
    public class GetCat :IFabric
    {
        private readonly IParser parser;
        private readonly ICreator creator;
        public GetCat()
        {
            parser = new ToCatParser();
            creator = new CatCreator();
        }

        public IAnimal GetAnimal()
        {            
            return parser.Parse(creator.Create().Split(','));         
        }
        public override string ToString()=> "Кот";

    }
}
