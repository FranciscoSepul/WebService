namespace WsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tarjetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pan = c.String(),
                        MesVencimiento = c.Int(nullable: false),
                        Anovencimiento = c.Int(nullable: false),
                        CodigoSeguridad = c.Int(nullable: false),
                        NombreTarjeta = c.String(),
                        Pass = c.String(),
                        Disabled = c.String(),
                        Expires = c.DateTime(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        Comments = c.String(maxLength: 2000),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MontoMaximo = c.Int(nullable: false),
                        Disabled = c.String(),
                        Expires = c.DateTime(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        Comments = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarjetas", "User_Id", "dbo.Users");
            DropIndex("dbo.Tarjetas", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Tarjetas");
        }
    }
}
