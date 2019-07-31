using System;
using System.Collections.Generic;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.Interfaces
{
    public interface ILoginRepository
    {
        void CreateLogin<T>(T login) where T : class, IAggregationRoot;
        Guid UserLogin(string tel, string password);
    }
}
