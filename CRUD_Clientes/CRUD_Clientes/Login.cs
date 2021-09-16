using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Clientes.Models;


namespace CRUD_Clientes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {

            using (var db = new Models.ApplicationContext())
            {
                string str_login = edt_login.Text.Trim();
                string str_senha = edt_senha.Text.Trim();

                var usuario = db.Usuario
                    .Where(u => u.ds_login == str_login && str_senha == u.ds_senha)
                    .First();

                if(usuario != null)
                {
                    Forms.Dashboard dashboard = new Forms.Dashboard();
                    dashboard.Show();
                    this.Hide();
                } 
                else
                {

                }


            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

        }
    }
}
