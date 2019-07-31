using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.dbentity
{
    public partial  class Dealers : IAggregationRoot
    {
        public Dealers() { }

        public string Code { get; set; }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public decimal TotalEleMoney { get; set; }
        public decimal JiangJInMoney { get; set; }
        public decimal TotalPV { get; set; }
        public CardType CardType { get; set; }
        public Level Level { get; set; }
        public int SubCount { get; set; }
        public List<Contact> Contacts { get; set; }
        public DealerTree DealerTree { get; set; }
    }
    public enum CardType : int
    {
        普通会员=1,
        银卡会员=2,
        金卡会员=3
    }
    public enum Level : int
    {
        片区经理=1,
        省区经理=2,
        大区经理=3,
        董事=4
    }
}
