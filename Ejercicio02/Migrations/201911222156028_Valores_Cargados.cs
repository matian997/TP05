namespace Ejercicio02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Valores_Cargados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountMovements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Amount = c.Double(nullable: false),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OverdraftLimit = c.Double(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Document_Number = c.String(),
                        Document_Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.AccountMovements", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Accounts", new[] { "Client_Id" });
            DropIndex("dbo.AccountMovements", new[] { "Account_Id" });
            DropTable("dbo.Clients");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountMovements");
        }
    }
}
