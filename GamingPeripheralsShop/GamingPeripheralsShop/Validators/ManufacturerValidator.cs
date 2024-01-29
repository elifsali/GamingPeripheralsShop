using FluentValidation;
using GamingPeripheralsShop.Models.Models.User;

namespace GamingPeripheralsShop.Validators
{
    public class ManufacturerValidator : AbstractValidator<Manufacturer>
    {
        public ManufacturerValidator() 
        {
            RuleFor(x => x.Id)
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2);
            RuleFor(x => x.Country)
                .NotEmpty()
                .MinimumLength(2);
        }
    }
}
