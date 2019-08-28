namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "tbl.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "tbl.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Categories_id = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("tbl.Categories", t => t.Categories_id, cascadeDelete: true)
                .Index(t => t.Categories_id);
            
            CreateTable(
                "tbl.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ImageF = c.String(nullable: false),
                        ImageS = c.String(),
                        ImageT = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("tbl.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "tbl.ProductAccesses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DateOfLock = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("tbl.Products", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("tbl.ProductAccesses", "Id", "tbl.Products");
            DropForeignKey("tbl.Images", "ProductId", "tbl.Products");
            DropForeignKey("tbl.Products", "Categories_id", "tbl.Categories");
            DropIndex("tbl.ProductAccesses", new[] { "Id" });
            DropIndex("tbl.Images", new[] { "ProductId" });
            DropIndex("tbl.Products", new[] { "Categories_id" });
            DropTable("tbl.ProductAccesses");
            DropTable("tbl.Images");
            DropTable("tbl.Products");
            DropTable("tbl.Categories");
        }
    }
}
