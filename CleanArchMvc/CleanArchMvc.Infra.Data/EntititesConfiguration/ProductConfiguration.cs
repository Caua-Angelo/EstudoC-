using CleanArchMvcDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.EntititesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //define que o atributo Id de Product é uma chave primária
            builder.HasKey(t => t.Id);

            //define que o atributo Name de Product tem o tamanho máximo de 100 e obrigatória(não nulo)
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

            //define que o atributo Description de Product tem o tamanho máximo de 200 e obrigatória(não nulo)
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            //define que o atributo Price de Product tem o tamanho máximo de 10,com duas casas decimais
            builder.Property(p => p.Price).HasPrecision(10, 2);

            //define que uma Category pode conter vários Products e que a chave estrangeira é a Id do category
            builder.HasOne(e => e.Category).WithMany(e => e.products).HasForeignKey(e => e.CategoryId);

        }
    }
}
