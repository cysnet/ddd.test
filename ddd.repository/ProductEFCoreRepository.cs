using ddd.domain.dbentity;
using ddd.domain.Implements;
using ddd.domain.Interfaces;
using ddd.infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.repository
{
    public class ProductEFCoreRepository : IProductRepository
    {
        private readonly DbContext context;
        public ProductEFCoreRepository(DbContext context)
        {
            this.context = context;
        }
        public void CreateProduct<T>(T productspu) where T : class, IAggregationRoot
        {
            var productdbcontext = this.context as ProductEFCoreContext;
            var productspunew = productspu as ProductSPU;
            try
            {
                productdbcontext.ProductSPU.Add(productspunew);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
