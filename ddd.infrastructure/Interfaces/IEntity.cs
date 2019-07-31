using System;

namespace ddd.infrastructure.Interfaces
{
    /*
     * Id是一个未来存储到数据库表中的技术主键，Code是领域对象的唯一业务标识符。
     * 你也可以扩展这个接口，定义两个实体比较接口(未来实现就是比较两个实体如果
     * Code一致，则代表两个实体相等)。
     */
    public interface IEntity
    {
        string Code { get; set; }
        Guid Id { get; set; }
    }
}
