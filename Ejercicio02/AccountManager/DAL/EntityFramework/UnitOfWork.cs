using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        //Constructor
        public UnitOfWork(AccountManagerDbContext pContext)
        {
            if (pContext == null)
            {
                throw new NotImplementedException();
            }
            this.AccountRepository = new AccountRepository(pContext);
            this.ClientRepository = new ClientRepository(pContext);
            this.iDbContext = pContext;
        }

        //Atributos
        private AccountManagerDbContext iDbContext;
        private bool iDisposedValue = false;

        public IAccountRepository AccountRepository { get; private set; }

        public IClientRepository ClientRepository { get; private set; }

        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }
        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }
    }
}
