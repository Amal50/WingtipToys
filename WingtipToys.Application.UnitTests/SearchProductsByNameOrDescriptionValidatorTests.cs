using NUnit.Framework;
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
        //I can put them all in one test
        [Test]
        [TestCase("a")]
        [TestCase(" ")]
        [TestCase(null)]
        public void Should_have_error_when_SearchText_is_LengthLessThan2_Or_Null_Or_WhiteSpace(string value)
        {
            var model = new SearchCarProductsByNameOrDescriptionQuery { SearchText = value };
            var result = validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(query => query.SearchText);
        }

    }
}
