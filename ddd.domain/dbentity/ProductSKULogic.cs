using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class ProductSKU
    {
        public ProductSKU CreateProductSKU(string productspuname, Guid productspuid,
    byte[] image, decimal dealerprice, decimal pv, string unit, string spec)
        {
            this.Id = Guid.NewGuid();
            this.ProductSPUId = productspuid;
            this.Code = "Code " + productspuname + spec;
            this.ProductSPUName = productspuname;
            this.Image = image;
            this.DealerPrice = dealerprice;
            this.PV = pv;
            switch (unit)
            {
                case "盒":
                    this.Unit = Unit.盒;
                    break;
                case "包":
                    this.Unit = Unit.包;
                    break;
                case "瓶":
                    this.Unit = Unit.瓶;
                    break;
            }
            this.Spec = spec;
            return this;
        }
    }
}
