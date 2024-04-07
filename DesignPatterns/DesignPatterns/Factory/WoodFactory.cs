using DesignPatterns.Abstracts;
using DesignPatterns.Interfaces;
using DesignPatterns.Services;

namespace DesignPatterns.Factory
{
    public class WoodFactory : FurnitureAbstractFactory
    {
        public override IChairServices ChairServices()
        {
            return new WoodChairServices();
        }

        public override ITableServices TableServices()
        {
            return new WoodTableServices();
        }
    }
}
