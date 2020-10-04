using System;
using NSE.Core.DomainObjects;

namespace NSE.Catalog.API.Models
{
    public class Product : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Quantidady { get; set; }
    }
}