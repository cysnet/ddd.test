using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ddd.repository
{
    public class LoginEFCoreRepository : ILoginRepository
    {
        private readonly DbContext context;
        public LoginEFCoreRepository(DbContext context)
        {
            this.context = context;
        }
        public Guid UserLogin(string tel, string password)
        {
            throw new NotImplementedException();
        }

        void ILoginRepository.CreateLogin<T>(T login)
        {
            throw new NotImplementedException();
        }
    }
}
