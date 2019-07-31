using System;
using System.Collections.Generic;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.dbentity
{
    public partial class Contact : IValueObject
    {
        public Contact() { }
        public Guid Id { get; set; }
        public string ContactName { get; set; }
        public Guid DealerId{ get;set; }
        public string ContactTel { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Zero { get; set; }
        public string Street { get; set; }
        public IsDefaultContact IsDefault { get; set; }
    }
    public enum IsDefaultContact : int
    {
        默认=1,
        非默认=2
    }
}
