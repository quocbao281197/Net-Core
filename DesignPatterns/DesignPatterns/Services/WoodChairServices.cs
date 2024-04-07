using DesignPatterns.Interfaces;

namespace DesignPatterns.Services
{
    public class WoodChairServices : IChairServices
    {
        public string Create()
        {
            return "Created Wood Char";
        }
    }
}
