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
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(587, 314);
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
            lbSenha.Location = new Point(547, 194);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 1;
            lbSenha.Text = "Senha";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(547, 141);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(159, 23);
            txbLogin.TabIndex = 2;
            txbLogin.TextChanged += textBox1_TextChanged;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(547, 123);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(37, 15);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Login";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(547, 212);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(159, 23);
            txbSenha.TabIndex = 2;
            txbSenha.TextChanged += textBox1_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbSenha);
            Controls.Add(txbLogin);
            Controls.Add(lbLogin);
            Controls.Add(lbSenha);
            Controls.Add(btnLogar);
            Name = "FormLogin";
            Text = resources.GetString("$this.Text");
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private Label lbSenha;
        private TextBox txbLogin;
        private Label lbLogin;
        private TextBox txbSenha;
    }
}