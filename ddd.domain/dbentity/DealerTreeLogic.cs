using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.Interfaces;

namespace ddd.domain.dbentity
{
    public partial class DealerTree
    {
        private readonly IDealerRepository idealerrepository;
        public DealerTree(IDealerRepository idealerrepository)
        {
            this.idealerrepository = idealerrepository;
        }
        public DealerTree CreateDealerTree(Guid? parentdealerid,Guid dealerid)
        {
            this.Id = Guid.NewGuid();
            this.DealerId = dealerid;
            this.ParentDealerId = parentdealerid;
            this.Layer = parentdealerid == null ? 1 : idealerrepository.GetParentDealerLayer(Guid.Parse(parentdealerid.ToString())) + 1;
            return this;
        }
    }
}
