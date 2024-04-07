using DesignPatterns.Interfaces;

namespace DesignPatterns.Services
{
    public class VietcombankServices : IBankServices
    {
        public string getBankName()
        {
            return "Vietcombank";
        }
    }
}
