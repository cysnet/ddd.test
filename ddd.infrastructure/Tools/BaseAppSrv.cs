using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.infrastructure.Tools
{
    public class BaseAppSrv
    {
        protected ResultEntity<T> GetResultEntity<T>(T vobj, string msg = "未成功获取到对象", int errorcode = 0)
        {
            var ueresult = new ResultEntity<T>();
            var issuccess = true;
            if (vobj is int && Convert.ToInt32(vobj) <= 0)
            {
                issuccess = false;
            }
            else if (vobj is bool && !Convert.ToBoolean(vobj))
            {
                issuccess = false;
            }
            else if (vobj is string && string.IsNullOrEmpty(Convert.ToString(vobj)))
            {
                issuccess = false;
            }
            if (!issuccess)
            {
                ueresult.Msg = msg;
                ueresult.ErrorCode = 200;
            }
            ueresult.IsSuccess = issuccess;
            ueresult.Data = vobj;
            return ueresult;
        }
    }
}
