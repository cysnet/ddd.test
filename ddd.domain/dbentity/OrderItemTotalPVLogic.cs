using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class OrderItemTotalPV
    {
        public OrderItemTotalPV() { }
        public OrderItemTotalPV CreateOrderItemTotalPV(ProductSKU productsku,int count)
        {
            this.SubTotalPV = productsku.PV * count;
            return this;
        }
    }
}
