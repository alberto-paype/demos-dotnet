namespace CRUD_Clientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMenu3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SubMenus", new[] { "Menu_id" });
            CreateIndex("dbo.SubMenus", "menu_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SubMenus", new[] { "menu_id" });
            CreateIndex("dbo.SubMenus", "Menu_id");
        }
    }
}
