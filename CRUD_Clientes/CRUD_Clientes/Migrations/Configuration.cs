namespace CRUD_Clientes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUD_Clientes.Models.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.ApplicationContext context)
        {
            //Observar como se faz para dar rollback em uma transação
            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {

                    /*var usuario = new Usuario()
                    {
                        nm_usuario = "alberto pimentel",
                        ds_login = "a.pimentel",
                        ds_senha = "1234",
                        nm_email = "alberto.pimentel.94@gmail.com",
                        fl_ativo = true
                    };
                    context.Usuario.Add(usuario);
                    context.SaveChanges();

                    var cliente = new Cliente()
                    {
                        nm_cpf = "055.447.499-90",
                        ds_endereco = "Rua Aristides da fonseca, 334"
                    };
                    context.Cliente.Add(cliente);
                    context.SaveChanges();*/

                    for (int i = 0; i < 14; i++)
                    {

                        Menu menu = new Menu()
                        {
                            ds_titulo = $"Menu {i}",
                            ds_icone = "obrigatorio"
                        };

                        context.Menu.Add(menu);
                        

                        for (int x = 0; x < 3; x++)
                        {
                            SubMenu sub_menu = new SubMenu()
                            {
                                ds_titulo = $"Sub_menu {x}",
                                ds_icone = "icone",
                                int_ordem = 1,
                            };
                            sub_menu.menu = menu;
                            context.SubMenu.Add(sub_menu);
                        }

                    };

                    context.SaveChanges();
                    dbContextTransaction.Commit();

                }
                catch (DbEntityValidationException e)
                {
                    dbContextTransaction.Rollback();

                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                }

            }
        }
    }
}
