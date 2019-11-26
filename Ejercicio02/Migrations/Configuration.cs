namespace Ejercicio02.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using System.Linq;
    using AccountManager.Domain;
 
    internal sealed class Configuration : DbMigrationsConfiguration<Ejercicio02.AccountManager.DAL.EntityFramework.AccountManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Ejercicio02.AccountManager.DAL.EntityFramework.AccountManagerDbContext";
        }

        protected override void Seed(AccountManager.DAL.EntityFramework.AccountManagerDbContext context)
        {
            List<AccountMovement> accountMovements = new List<AccountMovement>
            {
                new AccountMovement { Id = 1, Description = "Compra en Aliexpress", Date = DateTime.Parse("27/10/2019"), Amount= double.Parse("3400.54")},
                new AccountMovement { Id = 2, Description = "Compra de celular", Date = DateTime.Parse("12/09/2019"), Amount= double.Parse("28000.43")},
                new AccountMovement { Id = 3, Description = "Compra en Banggood", Date = DateTime.Parse("20/09/2019"), Amount= double.Parse("1003.10")},
                new AccountMovement { Id = 4, Description = "Mantenimiento bancario", Date = DateTime.Parse("23/10/2019"), Amount= double.Parse("300.00")},
                new AccountMovement { Id = 5, Description = "Compra de zapatillas", Date = DateTime.Parse("06/11/2019"), Amount= double.Parse("2310.99")},
                new AccountMovement { Id = 6, Description = "Compra en MercadoLibre", Date = DateTime.Parse("12/08/2019"), Amount= double.Parse("950.00")},
                new AccountMovement { Id = 7, Description = "Impuesto por Compra en el extranjero", Date = DateTime.Parse("20/10/2019"), Amount= double.Parse("3400")}
            };
            foreach (AccountMovement movement in accountMovements)
            {
                context.AccountMovements.Add(movement);
                context.SaveChanges();
            }
            var accounts = new List<Account>
            {
                new Account { Id=1, Movements=accountMovements, Name="Cuenta corriente", OverdraftLimit=25000}
            };

            foreach (Account account in accounts)
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
            Document document = new Document {Number = "41043037", Type = DocumentType.DNI};
            var clients = new List<Client>
            {
                new Client {Id = 1, FirstName = "Juan Pablo", LastName = "Ortiz", Accounts=accounts, Document=document}
            };
            foreach (Client client in clients)
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }
    }
}
