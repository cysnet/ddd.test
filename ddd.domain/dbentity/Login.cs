using ddd.infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class Login: IAggregationRoot
    {
        public Login() { }
        //代表登录的电话号码
        public string Code { get; set; }
        public string Password { get; set; }
        public Guid DealerId { get; set; }
        [Key]
        public Guid Id { get ; set ; }
    }
}
