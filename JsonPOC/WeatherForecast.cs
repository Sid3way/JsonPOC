using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JsonPOC
{
    //public record WeatherForecast(
    //    [Range(0, 10, ErrorMessage = "Shouldn't be this cold or hot anyway. Only temperature between 0 and 10 are accepted")]
    //    int Temperature,
    //    [Required]
    //    string Summary,
    //    [WeirdValidation]
    //    string WeirdString,
    //    string BullshitString);
    public class WeatherForecast : IValidatableObject
    {
        [Range(0, 10, ErrorMessage = "Shouldn't be this cold or hot anyway. Only temperature between 0 and 10 are accepted")]
        public int Temperature { get; set; }

        [Required]
        public string Summary { get; set; }

        //[WeirdValidation]
        public string WeirdString { get; set; }

        public string BullshitString { get; set; }

        public WChild Child { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (BullshitString != "Bullshit")
                yield return new ValidationResult("Should contain \"Bullshit\"", new[] { nameof(BullshitString) });
            if (WeirdString != "Hello there")
                yield return new ValidationResult("Should contain \"Hello there\"", new[] { nameof(WeirdString) });
        }
    }

    public class WChild
    {
        [Required]
        public string ChildName { get; set; }
    }
}
