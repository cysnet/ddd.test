using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using ddd.infrastructure.Interfaces;
using ddd.infrastructure.Tools;

namespace ddd.service.UseCase
{
    public class CreateOrderUseCase : BaseAppSrv
    {
        private readonly IOrderRepository iorderrepository;
        private readonly IDealerRepository idealerrepository;
        private readonly IRepository[] irepositories;


        public CreateOrderUseCase(IOrderRepository iorderrepository, IDealerRepository idealerrepository,
            params IRepository[] irepositories)
        {
            this.iorderrepository = iorderrepository;
            this.idealerrepository = idealerrepository;
            this.irepositories = irepositories;
        }
        public ResultEntity<bool> CreateOrder(dynamic orderdto)
        {
            var orderid = Guid.NewGuid();
            Orders order = new Orders();
            var productskus = new List<ProductSKU>();
            for (int i = 0; i < orderdto.ProductSPUNames.Count; i++)
            {
                var productsku = new ProductSKU();
                productsku.ProductSPUName = orderdto.ProductSPUNames[i];
                productsku.DealerPrice = orderdto.ProductDealerPrices[i];
                productsku.PV = orderdto.ProductPVS[i];
                productsku.Id = orderdto.ProductSKUIds[i];
                productsku.Spec = orderdto.ProductSepcs[i];
                productskus.Add(productsku);
            }
            var contact = new Contact();
            contact.ContactName = orderdto.ContactName;
            contact.ContactTel = orderdto.ContactTel;
            contact.Province = orderdto.Privence;
            contact.City = orderdto.City;
            contact.Zero = orderdto.Zero;
            contact.Street = orderdto.Street;

            var orders = order.CreateOrders(orderid, orderdto.DealerId, productskus, orderdto.Counts,
                contact);

            try
            {
                //using (var tansaction = new TransactionScope())
                //{
                using (irepositories[1])
                {
                    idealerrepository.SubParentEleMoney(orderdto.DealerId, order.OrderTotalPrice.TotalPrice);
                    idealerrepository.AddDealerPV(orderdto.DealerId, order.OrderTotalPV.TotalPV);
                    irepositories[1].Commit();

                }

                using (irepositories[0])
                {
                    iorderrepository.CreateOrder(orders);
                    irepositories[0].Commit();
                }
                return GetResultEntity(true);
                //tansaction.Complete();
                //}
            }
            catch (Exception error)
            {
                throw error;
            }

        }
    }
}
