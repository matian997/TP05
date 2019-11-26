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
        /// <summary>
        /// Retorna el balance de la cuenta
        /// </summary>
        /// <returns></returns>
        public double GetBalance()
        {
            return (from movement in this.Movements select movement.Amount).Sum();
        }
        /// <summary>
        /// Retorna una lista de los movimientos de la cuenta
        /// </summary>
        /// <param name="pCount"></param>
        /// <returns></returns>
        public IEnumerable<AccountMovement> GetLastMovements(int pCount)
        {
            return this.Movements.OrderByDescending(pMovement => pMovement.Date).Take(pCount);
        }
    }
}
