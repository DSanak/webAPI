using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Product
    {

        public Product(Guid id, string name, bool isAvalible)
        {
            Id = id;
            Name = name;
            IsAvalible = isAvalible;
        }

        public Guid Id { get; }
        public string Name { get; }
        public bool IsAvalible { get; }


    }
}
