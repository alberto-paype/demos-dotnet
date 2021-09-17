﻿namespace CRUD_Clientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ds_titulo = c.String(nullable: false),
                        ds_icone = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
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
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Menus", t => t.Menu_id)
                .Index(t => t.Menu_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubMenus", "Menu_id", "dbo.Menus");
            DropIndex("dbo.SubMenus", new[] { "Menu_id" });
            DropTable("dbo.SubMenus");
            DropTable("dbo.Menus");
        }
    }
}
