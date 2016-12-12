namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_SchemaChanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDescription",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        ModifiedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProductNumber = c.Int(nullable: false),
                        Color = c.String(),
                        SafetyStockNumb = c.Int(nullable: false),
                        StockNumber = c.Int(nullable: false),
                        ReorderPoint = c.Boolean(nullable: false),
                        StandardCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDescription", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductDescription", new[] { "ProductId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductDescription");
        }
    }
}
