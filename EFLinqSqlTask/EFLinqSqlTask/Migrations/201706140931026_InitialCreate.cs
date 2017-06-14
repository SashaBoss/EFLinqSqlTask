namespace EFLinqSqlTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        Model = c.String(maxLength: 128),
                        Speed = c.Int(nullable: false),
                        Ram = c.Int(nullable: false),
                        Hd = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Screen = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Products", t => t.Model)
                .Index(t => t.Model);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Model = c.String(nullable: false, maxLength: 128),
                        Maker = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Model);
            
            CreateTable(
                "dbo.PCs",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        Model = c.String(maxLength: 128),
                        Speed = c.Int(nullable: false),
                        Ram = c.Int(nullable: false),
                        Hd = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cd = c.String(),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Products", t => t.Model)
                .Index(t => t.Model);
            
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        Model = c.String(maxLength: 128),
                        Type = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Products", t => t.Model)
                .Index(t => t.Model);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Printers", "Model", "dbo.Products");
            DropForeignKey("dbo.PCs", "Model", "dbo.Products");
            DropForeignKey("dbo.Laptops", "Model", "dbo.Products");
            DropIndex("dbo.Printers", new[] { "Model" });
            DropIndex("dbo.PCs", new[] { "Model" });
            DropIndex("dbo.Laptops", new[] { "Model" });
            DropTable("dbo.Printers");
            DropTable("dbo.PCs");
            DropTable("dbo.Products");
            DropTable("dbo.Laptops");
        }
    }
}
