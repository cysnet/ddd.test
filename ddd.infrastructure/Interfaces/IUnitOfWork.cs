using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.infrastructure.Interfaces
{
    /*
     * 工作单元接口就定义了一个提交方法，在具体实现时，
     * 其实就是对应的EF Core的整个聚合的事务提交方法。
     */
    public interface IUnitOfWork
    {
        void Commit();
    }
}
