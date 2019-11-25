using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.Domain
{
    public class Account
    {   //Propiedades
        public int Id { get; set; }
        public  String Name { get; set; }
        public double OverdraftLimit { get; set; }

        public virtual IList<AccountMovement> Movements { get; set; } = new List<AccountMovement>();

        //Metodos
        public double GetBalance()
        {
            return (from movement in this.Movements select movement.Amount).Sum();
        }

        public IEnumerable<AccountMovement> GetLastMovements(int pCount = 7)
        {
            return this.Movements.OrderByDescending(pMovement => pMovement.Date).Take(pCount);
        }
    }
}
