using FluentValidation;

namespace JsonPOC
{

    //public record PriceTag(string ProductName, string EAN, float Price, string Currency, PTChild Child);
    public class PriceTag
    {
        public string ProductName { get; set; }
        public string EAN { get; set; }
        public float Price { get; set; }
        public string Currency { get; set; }
        public PTChild Child { get; set; }

    }

    public class PTChild
    {
        public string ChildName { get; set; }
    }

    public class PriceTagValidator : AbstractValidator<PriceTag>
    {
        public PriceTagValidator()
        {
            RuleFor(pt => pt.EAN).Length(13);
            RuleFor(pt => pt.Currency).Length(3).Equal("EUR").WithMessage("Only EUR is accepted as currency");
            RuleFor(pt => pt.ProductName).NotEmpty();
            RuleFor(pt => pt.Price).InclusiveBetween(13, 42);
        }
    }

    public class PTChildValidator : AbstractValidator<PTChild>
    {
        public PTChildValidator()
        {
            RuleFor(ptc => ptc.ChildName).Length(1);
        }
    }


}
