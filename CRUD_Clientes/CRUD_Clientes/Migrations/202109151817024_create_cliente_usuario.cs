namespace CRUD_Clientes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_cliente_usuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nm_cpf = c.String(),
                        ds_endereco = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nm_usuario = c.String(),
                        ds_login = c.String(),
                        ds_senha = c.String(),
                        nm_email = c.String(),
                        fl_ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Clientes");
        }
    }
}
