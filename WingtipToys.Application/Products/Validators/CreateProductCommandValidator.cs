using FluentValidation;
using WingtipToys.Application.Products.Commands;

namespace WingtipToys.Application.Products.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(r => r.ProductName).NotEmpty().MaximumLength(100).MinimumLength(2);
            RuleFor(r => r.Description).NotEmpty().MinimumLength(20);
            RuleFor(r => r.UnitPrice).GreaterThan(0);
        }
    }
}
