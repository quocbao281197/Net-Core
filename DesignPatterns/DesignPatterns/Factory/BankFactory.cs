using DesignPatterns.Enums;
using DesignPatterns.Interfaces;
using DesignPatterns.Services;

namespace DesignPatterns.Factory
{
    public class BankFactory
    {
        public BankFactory() { }
        public static IBankServices GetBankServices(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.Techcombank:
                    return new TechcombankServices();
                case BankType.Vietcombank:
                    return new VietcombankServices();
                default:
                    throw new ArgumentException("Bank does not support");
            }
        }
    }
}
