namespace DAL.Migrations
{
    using ROZETKA.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserCompressImage.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ROZETKA.Entities.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ROZETKA.Entities.EFContext context)
        {
                Categories categories = new Categories()
                {
                    Id = 0,
                    Name="NoteBook"
                };
            Categories images2 = new Categories()
            {
                Id = 1,
                Name = "Computers"
            };
            Categories images3 = new Categories()
            {
                Id = 2,
                Name = "Telephones"
            };
            Categories images4 = new Categories()
            {
                Id = 3,
                Name = "Other devices"
            };
            context.Images.AddOrUpdate(t => t.Id, categories);
            context.Images.AddOrUpdate(t => t.Id, images1);
            context.Images.AddOrUpdate(t => t.Id, images2);
            context.Images.AddOrUpdate(t => t.Id, images3);


            for (int i = 0; i < 5; i++)
            {
                Product product = new Product()
                {
                    Id = i + 1,
                    Price = i*4500,
                    Name = $"Notebook{i}",
                    ImageT = $"../ImageT{i + 1}.jpg",
                    if(i<=2)
                    Categories_id=0
                        else Categories_id=1
                };
                context.Products.AddOrUpdate(t => t.Id, product);
            }

            for (int i = 0; i < 5; i++)
            {
                Images images = new Images()
                {
                    Id = i + 1,
                    ImageF = $"../ImageF{i+1}.jpg",
                    ImageS = $"../ImageS{i+1}.jpg",
                    ImageT = $"../ImageT{i+1}.jpg",
                    ProductId= i+1
                };
                context.Images.AddOrUpdate(t => t.Id, images);
            }

           

        }
    }
}
