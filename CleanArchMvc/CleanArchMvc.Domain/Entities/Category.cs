
using CleanArchMvcDomain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvcDomain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);

        }
        public Category(int id, string name)
        {
            DomainExceptionValidation.When(Id < 0, "INVALID ID");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        public ICollection<Product> products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name.too short,minimum 3 characteres");

            Name = name;
        }
    }
}
