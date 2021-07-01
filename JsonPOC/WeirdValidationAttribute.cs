using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JsonPOC
{
    public class WeirdValidationAttribute : ValidationAttribute
    {
        public string GetErrorMessage() => $"Nuh uh, wrong answer. WeirdString should contain: \"Hello there\"";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var payload = (WeatherForecast)validationContext.ObjectInstance;

            if (payload.WeirdString != "Hello there")
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}
