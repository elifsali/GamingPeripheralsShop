using FluentValidation;
using GamingPeripheralsShop.Models.Models.User;
namespace GamingPeripheralsShop.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(x => x.Id)
                .NotNull()
                .GreaterThan(0);   
            RuleFor(x =>  x.Name)
                .NotEmpty()
                .MinimumLength(2);
            RuleFor(x => x.Price) 
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.ManufacturerId)
                .NotNull()
                .GreaterThan(0);
        }
    }
}
