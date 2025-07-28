namespace ProGEs
{
    partial class TelaEntrar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_telaLogin = new Panel();
            gbxEntrar = new GroupBox();
            btnEntrar = new Button();
            lblEsqueciSenha = new LinkLabel();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            pbxLogo = new PictureBox();
            pnl_telaLogin.SuspendLayout();
            gbxEntrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnl_telaLogin
            // 
            pnl_telaLogin.Controls.Add(gbxEntrar);
            pnl_telaLogin.Dock = DockStyle.Fill;
            pnl_telaLogin.Location = new Point(0, 0);
            pnl_telaLogin.Name = "pnl_telaLogin";
            pnl_telaLogin.Size = new Size(890, 533);
            pnl_telaLogin.TabIndex = 1;
            // 
            // gbxEntrar
            // 
            gbxEntrar.BackColor = Color.White;
            gbxEntrar.Controls.Add(btnEntrar);
            gbxEntrar.Controls.Add(lblEsqueciSenha);
            gbxEntrar.Controls.Add(txtSenha);
            gbxEntrar.Controls.Add(txtEmail);
            gbxEntrar.Controls.Add(pbxLogo);
            gbxEntrar.Location = new Point(223, 59);
            gbxEntrar.Name = "gbxEntrar";
            gbxEntrar.Size = new Size(444, 415);
            gbxEntrar.TabIndex = 1;
            gbxEntrar.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(20, 53, 112);
            btnEntrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(179, 349);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(95, 41);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsqueciSenha.LinkColor = Color.FromArgb(22, 148, 76);
            lblEsqueciSenha.Location = new Point(278, 304);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(106, 17);
            lblEsqueciSenha.TabIndex = 4;
            lblEsqueciSenha.TabStop = true;
            lblEsqueciSenha.Text = "Esqueci a Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.Gray;
            txtSenha.Location = new Point(62, 262);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(322, 29);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(62, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 29);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email de usuário";
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.ProGEs_logo_tradicional;
            pbxLogo.Location = new Point(-38, -69);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(520, 360);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 1;
            pbxLogo.TabStop = false;
            // 
            // TelaEntrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 244);
            Controls.Add(pnl_telaLogin);
            Name = "TelaEntrar";
            Size = new Size(890, 533);
            pnl_telaLogin.ResumeLayout(false);
            gbxEntrar.ResumeLayout(false);
            gbxEntrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_telaLogin;
        private GroupBox gbxEntrar;
        private Button btnEntrar;
        private LinkLabel lblEsqueciSenha;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private PictureBox pbxLogo;
    }
}
