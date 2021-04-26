using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace restfull_API_with_ASP.Net5._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fisrtNumber}/{secondNumber}")]
        public IActionResult Sum(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fisrtNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");

        }
        private decimal ConvertToDecimal(string value)
        {
            decimal decimalValue;
            if(decimal.TryParse(value, out decimalValue) ){
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string value)
        {
            double number;
            bool isNumber = double.TryParse(
                value,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number
                );
            return isNumber;
        }
    }
}
