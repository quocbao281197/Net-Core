using DesignPatterns.Abstracts;
using DesignPatterns.Interfaces;
using DesignPatterns.Services;

namespace DesignPatterns.Factory
{
    public class FlasticFactory : FurnitureAbstractFactory
    {
        public override IChairServices ChairServices()
        {
            return new FlasticChairServices();
        }

        public override ITableServices TableServices()
        {
            return new FlasticTableServices();
        }
    }
}
