using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.infrastructure.Interfaces
{
    /*
     * 值对象接口只需要保留一个技术主键即可，它没有业务标识符。
     * 在数据库中，值对象可能作为单独表存储，也可以作为实体的一部分存储。
     * 你也可以扩展这个接口，定义两个值对象比较接口
     * （未来实现就是比较两个值对象如果所有属性值一致，则代表两个值对象相等）。
     */
    public interface IValueObject
    {
        Guid Id { get; set; }
    }
}
