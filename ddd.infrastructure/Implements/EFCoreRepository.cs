using ddd.infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.infrastructure.Implements
{
    public class EFCoreRepository : IRepository
    {
        private readonly DbContext context;
        public EFCoreRepository(DbContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
