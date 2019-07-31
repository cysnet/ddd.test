using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class OrderStreet
    {
        public OrderStreet() { }
        public OrderStreet CreateOrderStreet(Contact contact)
        {
            this.Privince = contact.Province;
            this.City = contact.City;
            this.Zero = contact.Zero;
            this.Street = contact.Street;
            return this;
        }
    }
}
