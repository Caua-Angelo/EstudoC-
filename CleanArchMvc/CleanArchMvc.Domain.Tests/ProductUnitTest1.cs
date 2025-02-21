using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Validation;
using FluentAssertions;
using Xunit;
using System;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Teste para ver se passando os parâmentros corretos,a instância é criada")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(15, "namezinho", "descrição", 20.0m, 20, "NomeImagem");
            action.Should()
                .NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Teste para ver se passando o nome curto,mostraria uma mensagem de erro ")]
        public void CreateProduct_ShortNameValue_NameDomainException()
        {
            Action action = () => new Product(15, "no", "descrição", 20.0m, 20, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid name.too short,minimum 3 characteres");
        }

        [Fact(DisplayName = "Teste para ver se passando o nome vazio,mostraria uma mensagem de erro ")]
        public void CreateProduct_EmptyNameValue_NameDomainException()
        {
            Action action = () => new Product(15, "", "descrição", 20.0m, 20, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid name.Name is required");
        }
        [Fact(DisplayName = "Teste para ver se passando o nome nulo,mostraria uma mensagem de erro ")]
        public void CreateProduct_NullOrEmptyNameValue_NameDomainException()
        {
            Action action = () => new Product(15, null, "descrição", 20.0m, 20, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid name.Name is required");
        }

        [Fact(DisplayName = "Teste para ver se passando preço menor que 0,mostraria uma mensagem de erro ")]
        public void CreateProduct_InvalidPriceValue_NameDomainException()
        {
            Action action = () => new Product(15, "nomi", "descrição", -1m, 20, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("");
        }

        [Fact(DisplayName = "Teste para ver se passando estoque menor que 0,mostraria uma mensagem de erro ")]
        public void CreateProduct_InvalidStockValue_NameDomainException()
        {
            Action action = () => new Product(15, "nomi", "descrição", 20.0m, -1, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Teste para ver se passando um nome de imagem com mais de 250 characteres,mostraria uma mensagem de erro ")]
        public void CreateProduct_InvalidImageValue_NameDomainException()
        {
            Action action = () => new Product(15, "nomi", "descrição", 10m, 0, "Este é um exemplo de mensagem longa para ser utilizada em testes de unidade. A ideia é garantir que o sistema consiga lidar com textos extensos sem problemas, como truncamentos, quebras de linha ou erros de processamento. Além disso, é importante verificar como a aplicação lida com caracteres especiais, acentos (como á, é, í, ó, ú) e símbolos (ex.: @, #, $, %, &). Testar com mensagens longas também ajuda a validar a performance e a robustez do código, especialmente em cenários onde a entrada de dados é crítica. Por fim, lembre-se de incluir casos de teste para strings vazias, nulas e com espaços em branco!");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid image name,too long,maximum 250 characteres");
        }
        [Theory]
        [InlineData(-5)]

        public void CreateProduct_InvalidStockValue_ExceptionDomainNegativeValue(int value)
    }
}
