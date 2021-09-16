using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new UsuarioModel();
            db.Database.Connection.ConnectionString = "Data Source=HOMOLOGAESCALA;Initial Catalog=teste_demo;User ID=sa;Password=#escalasoft123";

            string nm_usuario = textEdit1.Text.Trim();

            var usuario2 = db.Usuario.Where(u => u.nm_usuario == nm_usuario).ToArray();

            var usuario = new Usuario { nm_usuario = "teste", idade = 34 };
            db.Usuario.Add(usuario);
            db.SaveChanges();
        }
    }
}
