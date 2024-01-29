using FluentValidation;
using GamingPeripheralsShop.Models.Models.Request;

namespace GamingPeripheralsShop.Validators
{
    public class GetProductsByManufacturerRequestValidator : AbstractValidator<GetProductsByManufacturerRequest>
    {
        public GetProductsByManufacturerRequestValidator() 
        {
            RuleFor(test => test.ManufacturerId)
                .NotNull()
                .GreaterThan(0);
            RuleFor(test => test.MinPrice)
                .InclusiveBetween(0, decimal.MaxValue)
                .When(test => test.MinPrice.HasValue);
            RuleFor(test => test.MaxPrice)
                .InclusiveBetween(0, decimal.MaxValue)
                .When(test => test.MaxPrice.HasValue);
            RuleFor(test => test.MinPrice)
                .LessThanOrEqualTo(test => test.MaxPrice)
                .When(test => test.MinPrice.HasValue && test.MaxPrice.HasValue);  
            
        }
    
    }
}
