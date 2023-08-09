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
            btnLogar = new Button();
            lbSenha = new Label();
            txbLogin = new TextBox();
            lbLogin = new Label();
            txbSenha = new TextBox();
            gpLogin = new GroupBox();
            gpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(115, 285);
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
            lbSenha.Location = new Point(75, 165);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha";
            // 
            // txbLogin
            // 
            txbLogin.BackColor = SystemColors.GradientActiveCaption;
            txbLogin.ForeColor = SystemColors.InactiveCaptionText;
            txbLogin.Location = new Point(75, 112);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(159, 23);
            txbLogin.TabIndex = 2;
            txbLogin.TextChanged += textBox1_TextChanged;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(75, 94);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(37, 15);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Login";
            // 
            // txbSenha
            // 
            txbSenha.BackColor = SystemColors.GradientActiveCaption;
            txbSenha.Location = new Point(75, 183);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(159, 23);
            txbSenha.TabIndex = 2;
            txbSenha.TextChanged += textBox1_TextChanged;
            // 
            // gpLogin
            // 
            gpLogin.Controls.Add(txbSenha);
            gpLogin.Controls.Add(txbLogin);
            gpLogin.Controls.Add(lbLogin);
            gpLogin.Controls.Add(lbSenha);
            gpLogin.Controls.Add(btnLogar);
            gpLogin.ForeColor = SystemColors.MenuHighlight;
            gpLogin.Location = new Point(492, 6);
            gpLogin.Name = "gpLogin";
            gpLogin.Size = new Size(304, 436);
            gpLogin.TabIndex = 3;
            gpLogin.TabStop = false;
            gpLogin.Text = "Bem Vindo";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._2052277;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(gpLogin);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormLogin";
            Text = resources.GetString("$this.Text");
            gpLogin.ResumeLayout(false);
            gpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogar;
        private Label lbSenha;
        private TextBox txbLogin;
        private Label lbLogin;
        private TextBox txbSenha;
        private GroupBox gpLogin;
    }
}