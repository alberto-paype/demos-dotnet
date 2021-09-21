using DevExpress.XtraBars;
using Newtonsoft.Json;
using Sistema_Desktop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Desktop.Views.Cadastro
{
    public partial class PessoaForm : DevExpress.XtraEditors.XtraForm
    {
        public PessoaForm()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var pessoa = new Pessoa();

                var json = JsonConvert.SerializeObject(pessoa);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var url = "http://localhost:57663/api/index";

                var response = await client.PostAsync(url, data);

                string result = response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}