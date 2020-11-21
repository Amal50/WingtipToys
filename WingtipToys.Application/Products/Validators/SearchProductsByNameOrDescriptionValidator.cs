using FluentValidation;
using WingtipToys.Application.Products.Queries;

namespace WingtipToys.Application.Products.Validators
{
    public class SearchProductsByNameOrDescriptionValidator :  AbstractValidator<SearchCarProductsByNameOrDescriptionQuery>
    {
        public SearchProductsByNameOrDescriptionValidator()
        {
            RuleFor(r => r.SearchText).NotEmpty().MinimumLength(2);
        }
    }
}
