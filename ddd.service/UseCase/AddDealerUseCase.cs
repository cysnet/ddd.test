using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using ddd.infrastructure.Interfaces;
using ddd.infrastructure.Tools;
using ddd.service.DTO;

namespace ddd.service.UseCase
{
    public class AddDealerUseCase : BaseAppSrv
    {
        private readonly IRepository irepository;
        private readonly IDealerRepository idealerrepository;
        private readonly ILoginRepository iloginrepository;
        public AddDealerUseCase(IRepository irepository, IDealerRepository idealerrepository,
            ILoginRepository iloginrepository)
        {
            this.irepository = irepository;
            this.idealerrepository = idealerrepository;
            this.iloginrepository = iloginrepository;
        }
        public ResultEntity<bool> AddDealer(AddDealerDTO adddealerdto)
        {
            var dealerid = Guid.NewGuid();
            var dealercontacts = new List<Contact>();
            for (int i = 0; i < adddealerdto.ContactNames.Count; i++)
            {
                var dealercontact = new Contact().CreateContact(dealerid, adddealerdto.ContactNames[i],
                    adddealerdto.ContactTels[i], adddealerdto.ContactProvinces[i],
                    adddealerdto.ContactCities[i], adddealerdto.ContactZeors[i], adddealerdto.ContactStreets[i],
                    adddealerdto.IsDefaultContact[i]);
                dealercontacts.Add(dealercontact);
            }
            var dealer = new Dealers(idealerrepository).RegisterDealer(dealerid, adddealerdto.Name,
                adddealerdto.Tel, adddealerdto.EleMoney, dealercontacts, adddealerdto.Parentid);
            var login = new Login().CreateLogin(dealer.Tel, dealerid);
            try
            {
                using (irepository)
                {
                    idealerrepository.CreateDealer(dealer);
                    if (adddealerdto.Parentid != null)
                    {
                        idealerrepository.SubParentEleMoney(Guid.Parse(adddealerdto.Parentid.ToString()),
                            adddealerdto.EleMoney);
                    }
                    idealerrepository.AddParentSubCount(adddealerdto.Parentid);
                    iloginrepository.CreateLogin(login);

                    irepository.Commit();
                }
                return GetResultEntity(true);
            }

            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
