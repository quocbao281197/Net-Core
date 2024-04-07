using DesignPatterns.Abstracts;
using DesignPatterns.Enums;
using DesignPatterns.Factory;
using DesignPatterns.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AbstractController : ControllerBase
    {
        [HttpGet]
        public string CreateFurniture(string materialType, bool isChair, bool isTable)
        {
            string result = string.Empty;
            MaterialType type;
            bool isValidMaterialType = Enum.TryParse(materialType, out type);
            if (isValidMaterialType)
            {
                FurnitureAbstractFactory furnitureFactory = FurnitureFactory.getFactory(type);
                
                if (isChair)
                {
                    IChairServices chair = furnitureFactory.ChairServices();
                    result += chair.Create();
                }

                if (isTable)
                {
                    ITableServices table = furnitureFactory.TableServices();
                    result += table.Create();
                }
            }
            return result;
        }
    }
}
