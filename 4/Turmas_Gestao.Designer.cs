namespace ProGEs
{
    partial class Turmas_Gestao
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
            pnlAlunosGestao = new Panel();
            btnRemover = new Button();
            btnAdicionar = new Button();
            btnBuscar = new Button();
            txtBuscarTurma = new TextBox();
            PanelTurmas = new Panel();
            lblTurmas = new Label();
            lblNumTurmas = new Label();
            dtgAlunos = new DataGridView();
            pnlAlunosGestao.SuspendLayout();
            PanelTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).BeginInit();
            SuspendLayout();
            // 
            // pnlAlunosGestao
            // 
            pnlAlunosGestao.BackColor = Color.FromArgb(230, 239, 244);
            pnlAlunosGestao.Controls.Add(btnRemover);
            pnlAlunosGestao.Controls.Add(btnAdicionar);
            pnlAlunosGestao.Controls.Add(btnBuscar);
            pnlAlunosGestao.Controls.Add(txtBuscarTurma);
            pnlAlunosGestao.Controls.Add(PanelTurmas);
            pnlAlunosGestao.Controls.Add(dtgAlunos);
            pnlAlunosGestao.Dock = DockStyle.Fill;
            pnlAlunosGestao.Location = new Point(0, 0);
            pnlAlunosGestao.Name = "pnlAlunosGestao";
            pnlAlunosGestao.Size = new Size(701, 533);
            pnlAlunosGestao.TabIndex = 4;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.DarkRed;
            btnRemover.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(375, 455);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(91, 32);
            btnRemover.TabIndex = 8;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(22, 148, 76);
            btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(203, 455);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(91, 32);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(251, 191, 36);
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(281, 91);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 31);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarTurma
            // 
            txtBuscarTurma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTurma.ForeColor = Color.Gray;
            txtBuscarTurma.Location = new Point(281, 39);
            txtBuscarTurma.Name = "txtBuscarTurma";
            txtBuscarTurma.Size = new Size(352, 29);
            txtBuscarTurma.TabIndex = 1;
            txtBuscarTurma.Text = "Digite o número da turma";
            // 
            // PanelTurmas
            // 
            PanelTurmas.BackColor = Color.FromArgb(22, 148, 76);
            PanelTurmas.Controls.Add(lblTurmas);
            PanelTurmas.Controls.Add(lblNumTurmas);
            PanelTurmas.Location = new Point(62, 29);
            PanelTurmas.Name = "PanelTurmas";
            PanelTurmas.Size = new Size(160, 110);
            PanelTurmas.TabIndex = 5;
            // 
            // lblTurmas
            // 
            lblTurmas.AutoSize = true;
            lblTurmas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurmas.ForeColor = Color.White;
            lblTurmas.Location = new Point(53, 65);
            lblTurmas.Name = "lblTurmas";
            lblTurmas.Size = new Size(58, 20);
            lblTurmas.TabIndex = 1;
            lblTurmas.Text = "Turmas";
            // 
            // lblNumTurmas
            // 
            lblNumTurmas.AutoSize = true;
            lblNumTurmas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTurmas.ForeColor = Color.White;
            lblNumTurmas.Location = new Point(68, 23);
            lblNumTurmas.Name = "lblNumTurmas";
            lblNumTurmas.Size = new Size(25, 30);
            lblNumTurmas.TabIndex = 0;
            lblNumTurmas.Text = "0";
            // 
            // dtgAlunos
            // 
            dtgAlunos.BackgroundColor = Color.White;
            dtgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlunos.GridColor = Color.Black;
            dtgAlunos.Location = new Point(26, 161);
            dtgAlunos.Name = "dtgAlunos";
            dtgAlunos.Size = new Size(643, 276);
            dtgAlunos.TabIndex = 4;
            // 
            // Turmas_Gestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlAlunosGestao);
            Name = "Turmas_Gestao";
            Size = new Size(701, 533);
            pnlAlunosGestao.ResumeLayout(false);
            pnlAlunosGestao.PerformLayout();
            PanelTurmas.ResumeLayout(false);
            PanelTurmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAlunosGestao;
        private Button btnRemover;
        private Button btnAdicionar;
        private Button btnBuscar;
        private TextBox txtBuscarTurma;
        private Panel PanelTurmas;
        private Label lblTurmas;
        private Label lblNumTurmas;
        private DataGridView dtgAlunos;
    }
}
