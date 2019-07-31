using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.dbentity
{
    public partial class OrderItem: IEntity
    {
        public string Code { get; set; }
        [Key]
        public Guid Id { get ; set ; }

        public OrderItemTotalPrice OrderItemTotalPrice { get; set; }
        public OrderItemTotalPV OrderItemTotalPV { get; set; }
        public ProductSKUs ProductSKUs { get; set; }

        public int Count { get; set; }
    }
}
