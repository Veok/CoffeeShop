using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoffeeShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ILogger<CoffeeShopController> _logger;

        public CoffeeShopController(ILogger<CoffeeShopController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Coffee> Get()
        {
            return new[]
            {
                new Coffee
                {
                    Name = "Palus Putredinis",
                    Type = "Espresso - Blend",
                    Manufacturer = "NieCzapla"
                },
                new Coffee
                {
                    Name = "Marley One",
                    Type = "Arabica - Beans",
                },
                new Coffee
                {
                    Name = "Lucafe",
                    Type = "Arabica - Beans",
                },
            };
        }
    }
}