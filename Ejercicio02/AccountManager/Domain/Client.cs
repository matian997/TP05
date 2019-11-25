using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.Domain
{
    public class Client
    {   //Propiedades
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Document Document { get; set; }
        public virtual IList<Account> Accounts {get; set;} = new List<Account>();
    }
}
