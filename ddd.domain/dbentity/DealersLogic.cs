using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.Interfaces;

namespace ddd.domain.dbentity
{
    public partial class Dealers
    {
        private readonly IDealerRepository idealerrepository;
        public Dealers(IDealerRepository idealerrepository)
        {
            this.idealerrepository = idealerrepository;
        }
        public Dealers RegisterDealer(Guid id,string name,string tel,decimal telmoney,List<Contact>
            contacts,Guid? parentid)
        {
            this.Id = id;
            this.Code = "Code " + name;
            this.Name = name;
            this.Tel = tel;
            this.TotalEleMoney = telmoney;
            if (telmoney < 2000)
            {
                this.CardType = CardType.普通会员;
            }
            else if (telmoney >= 2000 && telmoney < 4000)
            {
                this.CardType = CardType.银卡会员;
            }
            else
            {
                this.CardType = CardType.金卡会员;
            }
            this.SubCount = 0;
            this.TotalPV = 0;
            this.JiangJInMoney = 0;
            this.Contacts = contacts;
            this.DealerTree = new DealerTree(idealerrepository).CreateDealerTree(parentid, id);
            return this;
        }
    }
}
