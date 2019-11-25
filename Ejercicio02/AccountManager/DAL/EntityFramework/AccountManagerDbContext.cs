using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ejercicio02.Migrations;
using Ejercicio02.AccountManager.Domain;

namespace Ejercicio02.AccountManager.DAL.EntityFramework
{
    public class AccountManagerDbContext : DbContext
    {
        public AccountManagerDbContext() : base("AccountManager")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AccountManagerDbContext, Configuration>());
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountMovement> AccountMovements { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());

            base.OnModelCreating(pModelBuilder);
        }

    }
}
