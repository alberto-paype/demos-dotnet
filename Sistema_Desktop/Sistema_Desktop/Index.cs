using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Desktop.Views.Cadastro;

namespace Sistema_Desktop
{
    public partial class Index : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Index()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            PessoaForm pessoa_form = new PessoaForm();
            pessoa_form.Show();
        }
    }
}