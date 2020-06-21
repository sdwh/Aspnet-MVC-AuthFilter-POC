namespace Aspnet_MVC_AuthFilter_POC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql("Insert into Roles (Name) Values ('SystemAdmin')");
            Sql("Insert into Roles (Name) Values ('Admin')");
            Sql("Insert into Roles (Name) Values ('User')");
            Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('acc1','Ryan System Admin','pwd',1)");
            Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('acc2','Josh Admin','pwd',2)");
            Sql("Insert into Users (UserId,UserName,Password,RoleId) Values ('acc3','Kevin User','pwd',3)");

        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
