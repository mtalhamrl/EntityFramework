namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class my_project : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Classes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Products");
        }
    }
}
