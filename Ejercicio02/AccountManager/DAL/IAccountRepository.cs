using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.DAL
{
    public interface IAccountRepository : IRepository<Domain.Account>
    {
        IEnumerable<Domain.Account> GetOverdrawnAccounts();
    }
}
