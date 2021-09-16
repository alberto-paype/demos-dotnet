namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        idade = c.Int(nullable: false, identity: true),
                        nm_usuario = c.String(),
                        ds_login = c.String(),
                    })
                .PrimaryKey(t => t.idade);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
