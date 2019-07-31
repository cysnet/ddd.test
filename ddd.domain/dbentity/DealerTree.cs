using System;
using System.Collections.Generic;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.dbentity
{
    public partial class DealerTree : IValueObject
    {
        public DealerTree() { }
        public Guid Id { get; set; }
        public Guid DealerId { get; set; }
        public Guid? ParentDealerId { get; set; }
        public int Layer { get; set; }
    }
}
