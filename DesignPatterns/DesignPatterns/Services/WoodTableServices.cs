using DesignPatterns.Interfaces;

namespace DesignPatterns.Services
{
    public class WoodTableServices : ITableServices
    {
        public string Create()
        {
            return "Created Wood table";
        }
    }
}
