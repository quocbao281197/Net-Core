using DesignPatterns.Interfaces;

namespace DesignPatterns.Abstracts
{
    public abstract class FurnitureAbstractFactory
    {
        public abstract IChairServices ChairServices();
        public abstract ITableServices TableServices();
    }
}
