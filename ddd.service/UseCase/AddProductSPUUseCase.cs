using ddd.domain.dbentity;
using ddd.domain.Interfaces;
using ddd.infrastructure.Interfaces;
using ddd.infrastructure.Tools;
using ddd.service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.service.UseCase
{
    public class AddProductSPUUseCase : BaseAppSrv
    {
        private readonly IRepository irepositorycontext;
        private readonly IProductRepository iproductrepository;
        public AddProductSPUUseCase(IRepository irepositorycontext, IProductRepository iproductrepository)
        {
            this.irepositorycontext = irepositorycontext;
            this.iproductrepository = iproductrepository;
        }

        public ResultEntity<bool> AddProduct(AddProductSPUDTO addproductspudto)
        {
            var productspuid = Guid.NewGuid();
            var productskus = new List<ProductSKU>();
            for (int i = 0; i < addproductspudto.SKUSpecs.Count; i++)
            {
                var productsku = new ProductSKU().CreateProductSKU(addproductspudto.SPUName,
                    productspuid, addproductspudto.SKUImages[i], addproductspudto.SKUDealerPrices[i],
                    addproductspudto.SKUPvs[i], addproductspudto.SKUUnits[i], addproductspudto.SKUSpecs[i]);
                productskus.Add(productsku);
            }
            var productspu = new ProductSPU().CreateProductSPU(productspuid, addproductspudto.SPUName,
                addproductspudto.SPUDesc, productskus);
            try
            {
                using (irepositorycontext)
                {
                    iproductrepository.CreateProduct(productspu);
                    irepositorycontext.Commit();
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
