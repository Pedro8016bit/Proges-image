namespace ProGEs
{
    partial class TelaRedefinirSenha
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
            gbxRedefinirSenha = new GroupBox();
            btnRedefinir = new Button();
            txtNovaSenha = new TextBox();
            txtCodigo = new TextBox();
            pbxLogo = new PictureBox();
            txtConfirmarSenha = new TextBox();
            gbxRedefinirSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // gbxRedefinirSenha
            // 
            gbxRedefinirSenha.BackColor = Color.White;
            gbxRedefinirSenha.Controls.Add(txtConfirmarSenha);
            gbxRedefinirSenha.Controls.Add(btnRedefinir);
            gbxRedefinirSenha.Controls.Add(txtNovaSenha);
            gbxRedefinirSenha.Controls.Add(txtCodigo);
            gbxRedefinirSenha.Controls.Add(pbxLogo);
            gbxRedefinirSenha.Location = new Point(223, 59);
            gbxRedefinirSenha.Name = "gbxRedefinirSenha";
            gbxRedefinirSenha.Size = new Size(444, 415);
            gbxRedefinirSenha.TabIndex = 1;
            gbxRedefinirSenha.TabStop = false;
            // 
            // btnRedefinir
            // 
            btnRedefinir.BackColor = Color.FromArgb(20, 53, 112);
            btnRedefinir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRedefinir.ForeColor = Color.White;
            btnRedefinir.Location = new Point(169, 348);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(108, 41);
            btnRedefinir.TabIndex = 5;
            btnRedefinir.Text = "Redefinir";
            btnRedefinir.UseVisualStyleBackColor = false;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNovaSenha.ForeColor = Color.Gray;
            txtNovaSenha.Location = new Point(62, 239);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(322, 29);
            txtNovaSenha.TabIndex = 3;
            txtNovaSenha.Text = "Nova Senha";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.Gray;
            txtCodigo.Location = new Point(62, 193);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(322, 29);
            txtCodigo.TabIndex = 2;
            txtCodigo.Text = "Código de Recuperação";
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
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarSenha.ForeColor = Color.Gray;
            txtConfirmarSenha.Location = new Point(62, 288);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(322, 29);
            txtConfirmarSenha.TabIndex = 6;
            txtConfirmarSenha.Text = "Confirmar Senha";
            // 
            // TelaRedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 239, 244);
            Controls.Add(gbxRedefinirSenha);
            Name = "TelaRedefinirSenha";
            Size = new Size(890, 533);
            gbxRedefinirSenha.ResumeLayout(false);
            gbxRedefinirSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxRedefinirSenha;
        private TextBox txtConfirmarSenha;
        private Button btnRedefinir;
        private TextBox txtNovaSenha;
        private TextBox txtCodigo;
        private PictureBox pbxLogo;
    }
}
