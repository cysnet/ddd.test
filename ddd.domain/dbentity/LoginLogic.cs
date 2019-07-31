using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.domain.dbentity
{
    public partial class Login
    {
        public Login CreateLogin(string code,Guid dealerid)
        {
            this.Id = Guid.NewGuid();
            //手机号
            this.Code = code;
            //默认初始密码
            this.Password= "111111";
            this.DealerId = dealerid;
            return this;
        }
    }
}
