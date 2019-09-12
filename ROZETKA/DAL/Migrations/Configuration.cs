namespace DAL.Migrations
{
    using DAL.Entities;
    using ROZETKA.Entities;
    using System;
    using System.Data.Entity.Migrations;
    using UserCompressImage.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ROZETKA.Entities.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ROZETKA.Entities.EFContext context)
        {
            for (int i = 0; i <= 4; i+=2)
            {
                ProductAccess acc = new ProductAccess()
                {
                    Id = i + 1,
                    DateOfLock = DateTime.Now
                };
                context.ProductAccesses.AddOrUpdate(t => t.Id, acc);
            }

            Categories categories1 = new Categories()
                {
                    Id = 0,
                    Name="NoteBook"
                };
            Categories categories2 = new Categories()
            {
                Id = 1,
                Name = "Computers"
            };
            Categories categories3 = new Categories()
            {
                Id = 2,
                Name = "Telephones"
            };
            Categories categories4 = new Categories()
            {
                Id = 3,
                Name = "Other devices"
            };
            context.Categories.AddOrUpdate(t => t.Id, categories1);
            context.Categories.AddOrUpdate(t => t.Id, categories2);
            context.Categories.AddOrUpdate(t => t.Id, categories3);
            context.Categories.AddOrUpdate(t => t.Id, categories4);


            for (int i = 0; i < 5; i++)
            {
                Product product = new Product()
                {
                    Id = i + 1,
                    Price = i * 4500,
                    Name = $"Notebook{i}",
                    Categories_id = 1,
                    Description = "Sorry , this notebook not for you"
                };
                context.Products.AddOrUpdate(t => t.Id, product);
            }

            for (int i = 0; i < 5; i++)
            {
                Images images = new Images()
                {
                    Id = i + 1,
                    ImageF = $"../../Images/ImageF{i + 1}.jpg",
                    ImageS = $"../../Images/ImageS{i + 1}.jpg",
                    ImageT = $"../../Images/ImageT{i + 1}.jpg",
                };
                context.Images.AddOrUpdate(t => t.Id, images);
            }



        }
    }
}
