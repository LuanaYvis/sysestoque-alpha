namespace sysestoque_alpha
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            btnLogar = new Button();
            lbSenha = new Label();
            lbLogin = new Label();
            txbSenha = new TextBox();
            txbLogin1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Logotipo_Moderno_Tecnologia_e_Gaming_Roxo_removebg_preview;
            pictureBox1.Location = new Point(-118, -262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1004, 787);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(342, 375);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(302, 292);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(302, 225);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(37, 15);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Login";
            // 
            // txbSenha
            // 
            txbSenha.BackColor = SystemColors.GradientActiveCaption;
            txbSenha.ForeColor = SystemColors.InactiveCaptionText;
            txbSenha.Location = new Point(302, 320);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(159, 23);
            txbSenha.TabIndex = 2;
            txbSenha.TextChanged += textBox1_TextChanged;
            // 
            // txbLogin1
            // 
            txbLogin1.BackColor = SystemColors.GradientActiveCaption;
            txbLogin1.Location = new Point(302, 255);
            txbLogin1.Name = "txbLogin1";
            txbLogin1.Size = new Size(159, 23);
            txbLogin1.TabIndex = 2;
            txbLogin1.TextChanged += textBox1_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogar);
            Controls.Add(txbLogin1);
            Controls.Add(lbSenha);
            Controls.Add(lbLogin);
            Controls.Add(txbSenha);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = resources.GetString("$this.Text");
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnLogar;
        private Label lbSenha;
        private Label lbLogin;
        private TextBox txbSenha;
        private TextBox txbLogin1;
    }
}