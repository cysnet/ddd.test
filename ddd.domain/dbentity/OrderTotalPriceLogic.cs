using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class OrderTotalPrice
    {
        public OrderTotalPrice() { }
        public OrderTotalPrice CreateOrderTotalPrice(List<OrderItemTotalPrice> itemtotalprices)
        {
            var ordertotalprice = 0.00M;
            itemtotalprices.ForEach(p =>
            {
                ordertotalprice += p.SubTotalPrice;
            });
            this.TotalPrice = ordertotalprice;
            return this;
        }
    }
}
