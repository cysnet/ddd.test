using System;
using System.Collections.Generic;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.Interfaces
{
    public interface IDealerRepository
    {
        void CreateDealer<T>(T dealer) where T : class, IAggregationRoot;
        //获取上级经销商(当前代注册经销商)的层次结构
        int GetParentDealerLayer(Guid dealerid);
        //将上级经销商（代注册经销商）的子个数加一
        void AddParentSubCount(Guid? parentdealerid);
        //减去父进销商的电子币（用于注册和下单时，扣减经销商的电子币）
        void SubParentEleMoney(Guid parentdealerid, decimal subelemoney);
        //下订单时，增加经销商的PV
        void AddDealerPV(Guid dealerid, decimal orderpv);
    }
}
