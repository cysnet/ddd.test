using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class OrderStreet
    {
        //省
        public string Privince { get; set; }
        //市
        public string City { get; set; }
        //区(县)
        public string Zero { get; set; }
        //街道地址
        public string Street { get; set; }
    }
}
