using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Ejercicio02.AccountManager.DAL.EntityFramework
{
    public abstract class Repository<TEntity, TDbContext> : IRepository<TEntity> where TEntity : class
                                                                                 where TDbContext : DbContext
    {
        protected readonly TDbContext iDbContext;

        public Repository(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }
            this.iDbContext = pDbContext;
        }

        //Metodos
        /// <summary>
        /// Agrega una entidad
        /// </summary>
        /// <param name="pEntity"></param>
        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iDbContext.Set<TEntity>().Add(pEntity);
        }
        /// <summary>
        /// Retorna una entidad
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }
        /// <summary>
        /// Retorna una lista con todas las entidades
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>();
        }
        /// <summary>
        /// Remueve una entidad
        /// </summary>
        /// <param name="pEntity"></param>
        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}
    