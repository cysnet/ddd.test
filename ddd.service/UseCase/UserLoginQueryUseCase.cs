using System;
using System.Collections.Generic;
using System.Text;
using ddd.domain.Interfaces;
using ddd.infrastructure.Interfaces;
using ddd.infrastructure.Tools;
using ddd.service.DTO;

namespace ddd.service.UseCase
{
    public class UserLoginQueryUseCase : BaseAppSrv
    {
        private readonly IRepository irepository;
        private readonly ILoginRepository iloginrepository;
        public UserLoginQueryUseCase(IRepository irepository, ILoginRepository iloginrepository)
        {
            this.iloginrepository = iloginrepository;
            this.irepository = irepository;
        }
        public Guid Login(UserLoginDTO userlogindto)
        {
            try
            {
                using (irepository)
                {
                    return iloginrepository.UserLogin(userlogindto.Telphone, userlogindto.Password);
                }
            }
            catch (Exception error)
            {
                throw;
            }
        }
    }
}

