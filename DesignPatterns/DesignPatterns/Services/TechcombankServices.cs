using DesignPatterns.Interfaces;

namespace DesignPatterns.Services
{
    public class TechcombankServices : IBankServices
    {
        public string getBankName()
        {
            return "Techcombank";
        }
    }
}
