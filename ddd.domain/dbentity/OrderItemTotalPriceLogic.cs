using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class OrderItemTotalPrice
    {
        public OrderItemTotalPrice() { }
        public OrderItemTotalPrice CreateOrderItemTotalPrice(ProductSKU productsku,int count)
        {
            this.SubTotalPrice = productsku.DealerPrice * count;
            return this;
        }
    }
}
