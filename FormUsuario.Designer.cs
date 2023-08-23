namespace sysestoque_alpha
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            dgvUsuario = new DataGridView();
            Login = new DataGridViewTextBoxColumn();
            HashSenha = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblNome = new Label();
            lblSenha = new Label();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(713, 415);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(632, 415);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(551, 415);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.BackgroundColor = SystemColors.ControlLight;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { Login, HashSenha, Nome, Telefone, Email });
            dgvUsuario.Location = new Point(12, 229);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.Size = new Size(776, 165);
            dgvUsuario.TabIndex = 3;
            // 
            // Login
            // 
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Login";
            Login.Name = "Login";
            // 
            // HashSenha
            // 
            HashSenha.DataPropertyName = "HashSenha";
            HashSenha.HeaderText = "HashSenha";
            HashSenha.Name = "HashSenha";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtLogin);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Controls.Add(lblLogin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 199);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(450, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(83, 127);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 74);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(450, 26);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 6;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(83, 26);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(398, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(20, 130);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 77);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(378, 29);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(66, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "HashSenha";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(20, 29);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvUsuario);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Name = "FormUsuario";
            Text = "Tela de Usuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnSalvar;
        private DataGridView dgvUsuario;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNome;
        private Label lblSenha;
        private Label lblLogin;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn HashSenha;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
    }
}