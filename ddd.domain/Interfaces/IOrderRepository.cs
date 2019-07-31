using System;
using System.Collections.Generic;
using System.Text;
using ddd.infrastructure.Interfaces;

namespace ddd.domain.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder<T>(T order) where T:class,IAggregationRoot;
    }
}
