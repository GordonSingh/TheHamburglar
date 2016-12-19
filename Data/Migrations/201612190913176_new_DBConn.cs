namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_DBConn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductDescription", "ProductDescription_ProductId", c => c.Int());
            AddColumn("dbo.Products", "Product_ProductId", c => c.Int());
            CreateIndex("dbo.ProductDescription", "ProductDescription_ProductId");
            CreateIndex("dbo.Products", "Product_ProductId");
            AddForeignKey("dbo.Products", "Product_ProductId", "dbo.Products", "ProductId");
            AddForeignKey("dbo.ProductDescription", "ProductDescription_ProductId", "dbo.ProductDescription", "ProductId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDescription", "ProductDescription_ProductId", "dbo.ProductDescription");
            DropForeignKey("dbo.Products", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Product_ProductId" });
            DropIndex("dbo.ProductDescription", new[] { "ProductDescription_ProductId" });
            DropColumn("dbo.Products", "Product_ProductId");
            DropColumn("dbo.ProductDescription", "ProductDescription_ProductId");
        }
    }
}
