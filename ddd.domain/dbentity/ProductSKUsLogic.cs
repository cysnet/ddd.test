using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class ProductSKUs
    {
        public ProductSKUs() { }
        public ProductSKUs CreateProductSKUs(ProductSKU productsku)
        {
            this.ProductSPUName = productsku.ProductSPUName;
            this.ProductPrice = productsku.DealerPrice;
            this.ProductPV = productsku.PV;
            this.ProductSKUId = productsku.Id;
            return this;
        }
    }
}
