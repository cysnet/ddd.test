using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class ProductSPU
    {
        public ProductSPU CreateProductSPU(Guid id, string spuname, string spudesc, List<ProductSKU> productskus)
        {
            this.Id = id;
            this.Code = "Code " + spuname;
            this.ProductSPUName = spuname;
            this.ProductSKUS = productskus;
            this.ProductSPUDes = spudesc;
            return this;
        }
    }
}
