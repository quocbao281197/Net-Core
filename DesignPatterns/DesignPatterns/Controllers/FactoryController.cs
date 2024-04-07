using DesignPatterns.Enums;
using DesignPatterns.Factory;
using DesignPatterns.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactoryController : ControllerBase
    {

        [HttpGet("GetBankName")]
        public string GetBankName(string bankName)
        {
            BankType bankType;
            bool isValidBank = Enum.TryParse(bankName, out bankType);

            if (isValidBank)
            {
                IBankServices bankService = BankFactory.GetBankServices(bankType);
                return bankService.getBankName();
            }

            return "Not valid Bank";
            
        }
    }
}
