using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Validation;
using FluentAssertions;
namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName ="Create Category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }
    }
}