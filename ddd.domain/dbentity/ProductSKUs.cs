using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class ProductSKUs
    {
        public string ProductSPUName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductPV { get; set; }
        public Guid ProductSKUId { get; set; }
    }
}
