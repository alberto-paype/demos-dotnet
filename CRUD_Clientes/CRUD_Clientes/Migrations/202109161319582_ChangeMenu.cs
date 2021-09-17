namespace CRUD_Clientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMenu : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SubMenus", "Menu_id", "dbo.Menus");
            DropIndex("dbo.SubMenus", new[] { "Menu_id" });
            DropTable("dbo.SubMenus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SubMenus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ds_titulo = c.String(),
                        ds_icone = c.String(),
                        int_ordem = c.Int(nullable: false),
                        Menu_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.SubMenus", "Menu_id");
            AddForeignKey("dbo.SubMenus", "Menu_id", "dbo.Menus", "id");
        }
    }
}
