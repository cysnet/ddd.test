using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class Orders
    {
        public Orders CreateOrders(Guid id,Guid dealerid,List<ProductSKU> productskus,  List<int> counts,Contact contact)
        {
            this.Id = id;
            this.OrderDealerId = dealerid;
            this.OrderDateTime = DateTime.Now;
            this.Telephone = contact.ContactTel;
            this.Code = "Order " + DateTime.Now.ToString();

            this.OrderStreet = new OrderStreet().CreateOrderStreet(contact);
            this.OrderItems = new List<OrderItem>();
            var orderitemtotalprices = new List<OrderItemTotalPrice>();
            var orderitemtotalpvs = new List<OrderItemTotalPV>();
            for(int i = 0; i < productskus.Count; i++)
            {
                var orderitem = new OrderItem().CreateOrderItem(productskus[i], counts[i]);
                this.OrderItems.Add(orderitem);
                orderitemtotalprices.Add(orderitem.OrderItemTotalPrice);
                orderitemtotalpvs.Add(orderitem.OrderItemTotalPV);
            }
            this.OrderTotalPrice = new OrderTotalPrice().CreateOrderTotalPrice(orderitemtotalprices);
            this.OrderTotalPV = new OrderTotalPV().CreateOrderTotalPV(orderitemtotalpvs);
            return this;
        }
    }
}
