using System.Threading;
using Data.Entities;

namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.AdventureContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.AdventureContext context)
        {
            #region Products

            var product = new Product
            {
                Name = "Jet Fuel",
                Color = "NA",
                ProductId = 1,
                ProductNumber = 12,
                ReorderPoint = false,
                SafetyStockNumb = 10,
                StandardCost = 2500.00,
                StockNumber = 100
            };
            context.Products.Add(product);

            var product2 = new Product
            {
                Name = "Steel Beams",
                Color = "Silverish Green",
                ProductId = 2,
                ProductNumber = 13,
                ReorderPoint = false,
                SafetyStockNumb = 12,
                StandardCost = 1500.50,
                StockNumber = 50
            };
            context.Products.Add(product2);

            var product3 = new Product
            {
                Name = "Daedra Heart",
                Color = "BLoody",
                ProductId = 3,
                ProductNumber = 14,
                ReorderPoint = false,
                SafetyStockNumb = 10,
                StandardCost = 15000.75,
                StockNumber = 100
            };
            context.Products.Add(product3);

            var product4 = new Product
            {
                Name = "Wood",
                Color = "Brown",
                ProductId = 4,
                ProductNumber = 15,
                ReorderPoint = false,
                SafetyStockNumb = 10,
                StandardCost = 15.50,
                StockNumber = 100
            };
            context.Products.Add(product4);

            #endregion

            #region ProductDescription

            var productDesc = new ProductDescription
            {
                ProductId = 1,
                Description = "Fuel for powering jets and shit. NB, Jet Fuel doesnt melt steel beams",
                ModifiedDateTime = DateTime.Now
            };
            context.ProductDescriptions.Add(productDesc);

            var productDesc2 = new ProductDescription
            {
                ProductId = 2,
                Description = "Support beams that can support shit and is not melted by Jet Fuel",
                ModifiedDateTime = DateTime.Now
            };
            context.ProductDescriptions.Add(productDesc2);

            var productDesc3 = new ProductDescription
            {
                ProductId = 3,
                Description = "Heart of a Daedric Demon which is pumping with the blood of his fallen enemies and crusted crimson red with his blood",
                ModifiedDateTime = DateTime.Now
            };
            context.ProductDescriptions.Add(productDesc3);

            var productDesc4 = new ProductDescription
            {
                ProductId = 4,
                Description = "It's wood. Nothing fancy, careful for splinters",
                ModifiedDateTime = DateTime.Now
            };
            context.ProductDescriptions.Add(productDesc4);
            #endregion

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
