using ddd.infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class ProductSPU : IAggregationRoot
    {
        public string Code { get; set; }
        [Key]
        public Guid Id { get; set; }
        public string ProductSPUName { get; set; }
        public string ProductSPUDes { get; set; }
        public List<ProductSKU> ProductSKUS { get; set; }
    }
}
