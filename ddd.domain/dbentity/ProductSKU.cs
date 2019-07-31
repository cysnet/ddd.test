using ddd.infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class ProductSKU : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Spec { get; set; }
        public Unit Unit { get; set; }
        public decimal PV { get; set; }
        public decimal DealerPrice { get; set; }
        public byte[] Image { get; set; }
        public Guid ProductSPUId { get; set; }
        public string ProductSPUName { get; set; }
    }
    public enum Unit
    {
        盒 = 1,
        包 = 2,
        瓶 = 3
    }
}
