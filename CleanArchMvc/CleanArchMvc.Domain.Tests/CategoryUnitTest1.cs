using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Validation;
using FluentAssertions;
namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        //Teste para identificar se quando uma instância de Category com os parâmetros corretos forem criados,não mostrará um mensagem de erro
        [Fact(DisplayName = "Create Category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }
        //Teste para identificar se quando uma instância de Category com o Id menor que zero for criado,mostrará uma mensagem de erro
        [Fact(DisplayName = "Create Category With Negative Id")]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }
        //Teste para identificar se quando uma instância de Category com Name menor que 3 characteres for criado,mostrará uma mensagem de erro
        [Fact(DisplayName = "Create Category With Less than 3 characteres")]
        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "Ca");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.too short,minimum 3 characteres");
        }
        //Teste para identificar se quando uma instância de Category com Name nulo ou vazio for criado,mostrará uma mensagem de erro
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