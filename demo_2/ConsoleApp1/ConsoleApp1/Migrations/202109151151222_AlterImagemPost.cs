namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterImagemPost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImagemPosts",
                c => new
                    {
                        ImagemPostId = c.Int(nullable: false, identity: true),
                        caminho = c.String(),
                    })
                .PrimaryKey(t => t.ImagemPostId);
            
            AddColumn("dbo.Posts", "Imagens_ImagemPostId", c => c.Int());
            CreateIndex("dbo.Posts", "Imagens_ImagemPostId");
            AddForeignKey("dbo.Posts", "Imagens_ImagemPostId", "dbo.ImagemPosts", "ImagemPostId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Imagens_ImagemPostId", "dbo.ImagemPosts");
            DropIndex("dbo.Posts", new[] { "Imagens_ImagemPostId" });
            DropColumn("dbo.Posts", "Imagens_ImagemPostId");
            DropTable("dbo.ImagemPosts");
        }
    }
}
