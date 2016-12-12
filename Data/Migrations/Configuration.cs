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

            var productDesc = new ProductDescription
            {
                ProductId = 1,
                Description = "Fuel for powering jets and shit. NB, Jet Fuel doesnt melt steel beams",
                ModifiedDateTime = DateTime.Now
            };
            context.ProductDescriptions.Add(productDesc);

            var productDesc2 = new ProductDescription
            {
                ProductId = 1,
                Description = "Support beams that can support shit and is not melted by Jet Fuel",
                ModifiedDateTime = DateTime.Now
            };
            context.ProductDescriptions.Add(productDesc);
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
