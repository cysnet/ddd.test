using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.infrastructure.Tools
{
    public class ResultEntity<T>
    {
        public bool IsSuccess { get; set; }
        public string Msg { get; set; }
        public T Data { get; set; }
        public int ErrorCode { get; set; }
        public int Count { get; set; }
    }
}
