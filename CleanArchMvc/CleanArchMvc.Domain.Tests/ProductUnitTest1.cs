using CleanArchMvcDomain.Entities;
using CleanArchMvcDomain.Validation;
using FluentAssertions;
using Xunit;
using System;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "se passando os parâmetros corretos,a instância é criada")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "namezinho", "descrição", 20.0m, 99, "NomeImagem");
            action.Should()
                .NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "se passando os id negativo,a instância é criada")]
        public void CreateProduct_WithNegativeIdValue_ResultObjectValidState()
        {
            Action action = () => new Product(-1, "namezinho", "descrição", 20.0m, 99, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "se passando o nome curto,mostraria uma mensagem de erro ")]
        public void CreateProduct_ShortNameValue_NameDomainException()
        {
            Action action = () => new Product(1, "no", "descrição", 20.0m, 99, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid name.too short,minimum 3 characteres");
        }
        [Fact(DisplayName = "se passando um nome de imagem com mais de 250 characteres,mostraria uma mensagem de erro ")]
        public void CreateProduct_InvalidImageValue_NameDomainException()
        {
            Action action = () => new Product(1, "Product Name", "descrição", 9.99m, 99, "Este é um exemplo de mensagem longa para ser utilizada em s de unidade. A ideia é garantir que o sistema consiga lidar com textos extensos sem problemas, como truncamentos, quebras de linha ou erros de processamento. Além disso, é importante verificar como a aplicação lida com caracteres especiais, acentos (como á, é, í, ó, ú) e símbolos (ex.: @, #, $, %, &). Testar com mensagens longas também ajuda a validar a performance e a robustez do código, especialmente em cenários onde a entrada de dados é crítica. Por fim, lembre-se de incluir casos de  para strings vazias, nulas e com espaços em branco!");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid image name,too long,maximum 250 characteres");
        }

        [Fact(DisplayName = "se passando o nome vazio,mostraria uma mensagem de erro ")]
        public void CreateProduct_EmptyNameValue_NameDomainException()
        {
            Action action = () => new Product(1, "", "descrição", 20.0m, 99, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid name.Name is required");
        }
        [Fact(DisplayName = "se passando o nome nulo,mostraria uma mensagem de erro ")]
        public void CreateProduct_NullOrEmptyNameValue_NameDomainException()
        {
            Action action = () => new Product(1, null, "descrição", 20.0m, 99, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("Invalid name.Name is required");
        }

        [Fact(DisplayName = "se passando preço menor que 0,mostraria uma mensagem de erro ")]
        public void CreateProduct_InvalidPriceValue_NameDomainException()
        {
            Action action = () => new Product(1, "Product Name", "descrição", -1m, 99, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>().WithMessage("invalid price value");
        }

        [Fact(DisplayName = "se passando estoque menor que 0,mostraria uma mensagem de erro ")]
        public void CreateProduct_InvalidStockValue_NameDomainException()
        {
            Action action = () => new Product(1, "nomi", "descrição", 20.0m, -1, "NomeImagem");
            action.Should()
                .Throw<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }


        [Fact(DisplayName = "se passando um nome de imagem vazio,não mostraria uma mensagem de erro ")]
        public void CreateProduct_WithEmptyImageName_ExceptionDomainNegativeValue()
        {
            Action action = () => new Product(1, "Product Name", "descrição", 20.0m, 50, "");
            action.Should().NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName =  "se passando um nome de imagem nulo,não mostraria uma mensagem de erro ")]
        public void CreateProduct_WithNullImageName_ExceptionDomainNegativeValue()
        {
            Action action = () => new Product(1, "Product Name", "descrição", 9.99m, 99, null);
            action.Should().NotThrow<CleanArchMvcDomain.Validation.DomainExceptionValidation>();
        }
        //[Theory]
        //[InlineData(-5)]
    }
}
