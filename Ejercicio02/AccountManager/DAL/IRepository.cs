using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.AccountManager.DAL
{
    public interface IRepository<TEntity> where TEntity: class
    {
        //Metodos
        /// <summary>
        /// Agrega una entidad
        /// </summary>
        /// <param name="pEntity"></param>
        void Add(TEntity pEntity);
        /// <summary>
        /// Remueve una entidad
        /// </summary>
        /// <param name="pEntity"></param>
        void Remove(TEntity pEntity);
        /// <summary>
        /// Retorna una entidad
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        TEntity Get(int pId);
        /// <summary>
        /// Retorna una lista de entidades
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
    }
}
