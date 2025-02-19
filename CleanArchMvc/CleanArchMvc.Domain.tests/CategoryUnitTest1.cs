using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Validation;
using CleanArchMvc.Domain;
using FluentAssertions;

namespace CleanArchMvc.Domain.tests
{
    public class CategoryUnitTest1
    {
        [Fact]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1,"Category Name");

            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }
    }
}