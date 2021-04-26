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
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
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

        [HttpGet("subtraction/{fisrtNumber}/{secondNumber}")]
        public IActionResult Sutraction(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(fisrtNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");

        }

        [HttpGet("multiplication/{fisrtNumber}/{secondNumber}")]
        public IActionResult Multiplication(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var product = ConvertToDecimal(fisrtNumber) * ConvertToDecimal(secondNumber);
                return Ok(product.ToString());
            }
            return BadRequest("Invalid Input");

        }

        [HttpGet("mean/{fisrtNumber}/{secondNumber}")]
        public IActionResult Mean(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var mean = (ConvertToDecimal(fisrtNumber) + ConvertToDecimal(secondNumber))/2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid Input");

        }

        [HttpGet("squareroot/{fisrtNumber}/{secondNumber}")]
        public IActionResult SquareRoot(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(fisrtNumber));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Invalid Input");

        }

        [HttpGet("quotient/{fisrtNumber}/{secondNumber}")]
        public IActionResult quotient(string fisrtNumber, string secondNumber)
        {
            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var quotient = ConvertToDecimal(fisrtNumber) / ConvertToDecimal(secondNumber);
                return Ok(quotient.ToString());
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
