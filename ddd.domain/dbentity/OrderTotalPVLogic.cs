using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class OrderTotalPV
    {
        public OrderTotalPV() { }
        public OrderTotalPV CreateOrderTotalPV(List<OrderItemTotalPV> itemtotalpvs)
        {
            var ordertotalpv = 0.00M;
            itemtotalpvs.ForEach(p =>
            {
                ordertotalpv += p.SubTotalPV;
            });
            this.TotalPV = ordertotalpv;
            return this;
        }
    }
}
