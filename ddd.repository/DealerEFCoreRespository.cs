using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ddd.domain.Implements;
using ddd.domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ddd.repository
{
    public class DealerEFCoreRespository : IDealerRepository
    {
        private readonly DbContext context;
        public DealerEFCoreRespository(DbContext context)
        {
            this.context = context;
        }
        public void AddDealerPV(Guid dealerid, decimal orderpv)
        {
            var dealercontext = this.context as DealerEFCoreContext;
            var dealer = dealercontext.Dealer.Single(p => p.Id == dealerid);
            dealer.TotalPV = dealer.TotalPV +orderpv;
            try
            {
                dealercontext.Entry(dealer).State = EntityState.Modified;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void AddParentSubCount(Guid? parentdealerid)
        {
            throw new NotImplementedException();
        }

        public int GetParentDealerLayer(Guid dealerid)
        {
            throw new NotImplementedException();
        }

        public void SubParentEleMoney(Guid parentdealerid, decimal subelemoney)
        {
            var dealercontext = this.context as DealerEFCoreContext;
            var parentdealer = dealercontext.Dealer.Single(p => p.Id == parentdealerid);
            parentdealer.TotalEleMoney = parentdealer.TotalEleMoney - subelemoney;
            if (parentdealer.TotalEleMoney < 0)
            {
                throw new Exception("电子币不够进行此操作!");
            }
            try
            {
                dealercontext.Entry(parentdealer).State = EntityState.Modified;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        void IDealerRepository.CreateDealer<T>(T dealer)
        {
            throw new NotImplementedException();
        }
    }
}
