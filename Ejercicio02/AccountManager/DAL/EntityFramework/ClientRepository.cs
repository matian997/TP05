using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.DAL.EntityFramework
{
    public class ClientRepository : Repository<Domain.Client, AccountManagerDbContext>, IClientRepository
    {
        //Constructor
        public ClientRepository(AccountManagerDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
