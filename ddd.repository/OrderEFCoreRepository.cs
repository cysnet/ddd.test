using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.dbentity;
using ddd.domain.Implements;
using ddd.domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ddd.repository
{
    public class OrderEFCoreRepository : IOrderRepository
    {
        private readonly DbContext context;

        public OrderEFCoreRepository(DbContext context)
        {
            this.context = context;
        }
        void IOrderRepository.CreateOrder<T>(T order)
        {
            var ordercontext = this.context as OrderEFCoreContext;
            var ordernew = order as Orders;
            try
            {
                ordercontext.Order.Add(ordernew);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
