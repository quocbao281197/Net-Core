using DesignPatterns.Abstracts;
using DesignPatterns.Enums;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Factory
{
    public class FurnitureFactory
    {
        public FurnitureFactory()
        {
            
        }

        public static FurnitureAbstractFactory getFactory(MaterialType materialType)
        {
            switch(materialType)
            {
                case MaterialType.Flastic:
                    return new FlasticFactory();
                case MaterialType.Wood:
                    return new WoodFactory();
                default:
                    throw new ArgumentException("Material does not supported");
            }
        }
    }
}
