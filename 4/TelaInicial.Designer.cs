namespace ProGEs
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            pnlFill = new Panel();
            pgbCarregamento = new ProgressBar();
            pbxLogo = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(20, 53, 112);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(890, 32);
            pnlSuperior.TabIndex = 0;
            pnlSuperior.MouseDown += pnlSuperior_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(854, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlFill
            // 
            pnlFill.BackColor = Color.FromArgb(230, 239, 244);
            pnlFill.Controls.Add(pgbCarregamento);
            pnlFill.Controls.Add(pbxLogo);
            pnlFill.Dock = DockStyle.Fill;
            pnlFill.Location = new Point(0, 32);
            pnlFill.Name = "pnlFill";
            pnlFill.Size = new Size(890, 539);
            pnlFill.TabIndex = 1;
            // 
            // pgbCarregamento
            // 
            pgbCarregamento.Location = new Point(301, 444);
            pgbCarregamento.Name = "pgbCarregamento";
            pgbCarregamento.Size = new Size(295, 24);
            pgbCarregamento.TabIndex = 1;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.ProGEs_logo_tradicional;
            pbxLogo.Location = new Point(99, -41);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(683, 586);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 571);
            Controls.Add(pnlFill);
            Controls.Add(pnlSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += TelaInicial_Load;
            KeyDown += TelaInicial_KeyDown;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Panel pnlFill;
        private PictureBox pbxLogo;
        private ProgressBar pgbCarregamento;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
    }
}
