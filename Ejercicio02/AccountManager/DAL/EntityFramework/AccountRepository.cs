using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.DAL.EntityFramework
{
    public class AccountRepository : Repository<Domain.Account, AccountManagerDbContext>, IAccountRepository
    {
        //Cosntructor
        public AccountRepository(AccountManagerDbContext pDbContext) : base(pDbContext)
        {
        }

        //Metodos
        /// <summary>
        /// Retorna una lista de 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Domain.Account> GetOverdrawnAccounts()
        {
            IList<Domain.Account> mOverdrawnAccounts = new List<Domain.Account>();
            foreach (var bAccount in this.GetAll())
            {
                var bAccountBalance = bAccount.GetBalance();
                if (bAccountBalance < 0 && System.Math.Abs(bAccountBalance) > bAccount.OverdraftLimit)
                {
                    mOverdrawnAccounts.Add(bAccount);
                }
            }
            return mOverdrawnAccounts;
        }
    }
}
