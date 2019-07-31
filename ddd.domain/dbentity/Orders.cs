using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.dbentity
{
    public partial class Orders: IAggregationRoot
    {
        public string Code { get; set ; }
        [Key]
        public Guid Id { get ; set; }

        public OrderStreet OrderStreet { get; set; }
        public OrderTotalPV OrderTotalPV { get; set; }
        public OrderTotalPrice OrderTotalPrice { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Guid OrderDealerId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public string Telephone { get; set; }
    }
}
