using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.infrastructure.Interfaces
{
    /*
     * 仓储接口从工作单元接口与资源释放接口继承，
     * 为未来的数据访问框架和可替换性提供顶层约束。
     */
    public interface IRepository : IUnitOfWork, IDisposable
    {
    }
}
