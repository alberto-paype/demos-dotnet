using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Clientes.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            using (var db = new Models.ApplicationContext()) 
            {

                var menus = db.Menu.Include("Sub_menus").ToList();                    
                menus.ForEach(menu =>
                {
                    RibbonPage page = new RibbonPage();
                    page.Text = menu.ds_titulo;
                    rib_menu.Pages.Add(page);
                });

            }
            
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rib_menu_Click(object sender, EventArgs e)
        {

        }
    }
}
