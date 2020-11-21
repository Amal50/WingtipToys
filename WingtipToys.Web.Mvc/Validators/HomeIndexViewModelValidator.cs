using FluentValidation;
using WingtipToys.Web.Mvc.Models;

namespace WingtipToys.Web.Mvc.Validators
{
    public class HomeIndexViewModelValidator : AbstractValidator<HomeIndexViewModel>
    {
        public HomeIndexViewModelValidator()
        {
            RuleFor(r => r.SearchText).NotEmpty().MinimumLength(2);
        }
    }
}
