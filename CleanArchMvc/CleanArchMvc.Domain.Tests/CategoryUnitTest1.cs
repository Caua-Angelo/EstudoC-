using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Validation;
using FluentAssertions;
namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create Category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Create Category With Negative Id")]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }
        [Fact(DisplayName = "Create Category With Less than 3 characteres")]
        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "Ca");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.too short,minimum 3 characteres");
        }
        [Fact(DisplayName = "Create Category Without Name")]
        public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, "");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required");
        }
    }

}