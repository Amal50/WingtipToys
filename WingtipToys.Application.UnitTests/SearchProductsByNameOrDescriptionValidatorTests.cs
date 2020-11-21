using NUnit.Framework;
using FluentValidation;
using FluentValidation.TestHelper;
using WingtipToys.Application.Products.Validators;
using WingtipToys.Application.Products.Queries;

namespace WingtipToys.Application.UnitTests
{
    [TestFixture]
    public class SearchProductsByNameOrDescriptionValidatorTests
    {
        private SearchProductsByNameOrDescriptionValidator validator;
        [SetUp]
        public void Setup()
        {
            validator = new SearchProductsByNameOrDescriptionValidator();
        }
        [Test]
        public void Should_have_error_when_SearchText_is_null()
        {
            var model = new SearchCarProductsByNameOrDescriptionQuery { SearchText = null };
            var result = validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(query => query.SearchText);
        }
        [Test]
        public void Should_have_error_when_SearchText_is_Length_LessThan_2()
        {
            var model = new SearchCarProductsByNameOrDescriptionQuery { SearchText = "a" };
            var result = validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(query => query.SearchText);
        }
        [Test]
        public void Should_have_error_when_SearchText_is_WhiteSpace()
        {
            var model = new SearchCarProductsByNameOrDescriptionQuery { SearchText = " " };
            var result = validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(query => query.SearchText);
        }
    }
}
