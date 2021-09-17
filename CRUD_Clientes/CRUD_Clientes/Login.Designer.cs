
namespace CRUD_Clientes
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.edt_login = new DevExpress.XtraEditors.TextEdit();
            this.edt_senha = new DevExpress.XtraEditors.TextEdit();
            this.chk_salvar_credenciais = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_login = new DevExpress.XtraEditors.LabelControl();
            this.lbl_senha = new DevExpress.XtraEditors.LabelControl();
            this.btn_acessar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sair = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lbl_mensagem = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.edt_login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_senha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_salvar_credenciais.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_login
            // 
            this.edt_login.EditValue = "a.pimentel";
            this.edt_login.Location = new System.Drawing.Point(72, 90);
            this.edt_login.Name = "edt_login";
            this.edt_login.Size = new System.Drawing.Size(195, 22);
            this.edt_login.TabIndex = 0;
            // 
            // edt_senha
            // 
            this.edt_senha.EditValue = "1234";
            this.edt_senha.Location = new System.Drawing.Point(72, 148);
            this.edt_senha.Name = "edt_senha";
            this.edt_senha.Size = new System.Drawing.Size(195, 22);
            this.edt_senha.TabIndex = 1;
            // 
            // chk_salvar_credenciais
            // 
            this.chk_salvar_credenciais.Location = new System.Drawing.Point(72, 176);
            this.chk_salvar_credenciais.Name = "chk_salvar_credenciais";
            this.chk_salvar_credenciais.Properties.Caption = "Salvar credenciais";
            this.chk_salvar_credenciais.Size = new System.Drawing.Size(195, 24);
            this.chk_salvar_credenciais.TabIndex = 2;
            // 
            // lbl_login
            // 
            this.lbl_login.Location = new System.Drawing.Point(72, 68);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(30, 16);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.Location = new System.Drawing.Point(72, 126);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(36, 16);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_acessar
            // 
            this.btn_acessar.Location = new System.Drawing.Point(72, 225);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(94, 29);
            this.btn_acessar.TabIndex = 5;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(173, 225);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(94, 29);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mensagem.Appearance.ForeColor = System.Drawing.Color.Coral;
            this.lbl_mensagem.Appearance.Options.UseForeColor = true;
            this.lbl_mensagem.Appearance.Options.UseTextOptions = true;
            this.lbl_mensagem.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbl_mensagem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbl_mensagem.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lbl_mensagem.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lbl_mensagem.Location = new System.Drawing.Point(72, 271);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(13, 16);
            this.lbl_mensagem.TabIndex = 7;
            this.lbl_mensagem.Text = "sd";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 316);
            this.Controls.Add(this.lbl_mensagem);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.chk_salvar_credenciais);
            this.Controls.Add(this.edt_senha);
            this.Controls.Add(this.edt_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.edt_login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_senha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_salvar_credenciais.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit edt_login;
        private DevExpress.XtraEditors.TextEdit edt_senha;
        private DevExpress.XtraEditors.CheckEdit chk_salvar_credenciais;
        private DevExpress.XtraEditors.LabelControl lbl_login;
        private DevExpress.XtraEditors.LabelControl lbl_senha;
        private DevExpress.XtraEditors.SimpleButton btn_acessar;
        private DevExpress.XtraEditors.SimpleButton btn_sair;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl lbl_mensagem;
    }
}

