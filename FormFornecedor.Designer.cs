namespace sysestoque_alpha
{
    partial class FormFornecedor
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
            label1 = new Label();
            textnome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textendereco = new TextBox();
            textCNPJ = new TextBox();
            label4 = new Label();
            textfone = new TextBox();
            textemail = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox5 = new PictureBox();
            btn_Salvar = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            dgvFornecedor = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Fone = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            btnAtualizar = new Button();
            btn_Excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome :";
            label1.Click += label1_Click;
            // 
            // textnome
            // 
            textnome.Location = new Point(97, 30);
            textnome.Name = "textnome";
            textnome.Size = new Size(244, 23);
            textnome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "CNPJ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 117);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Endereço :";
            // 
            // textendereco
            // 
            textendereco.Location = new Point(113, 117);
            textendereco.Name = "textendereco";
            textendereco.Size = new Size(449, 23);
            textendereco.TabIndex = 5;
            // 
            // textCNPJ
            // 
            textCNPJ.Location = new Point(97, 73);
            textCNPJ.Name = "textCNPJ";
            textCNPJ.Size = new Size(139, 23);
            textCNPJ.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 165);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Email :";
            // 
            // textfone
            // 
            textfone.Location = new Point(84, 159);
            textfone.Name = "textfone";
            textfone.Size = new Size(152, 23);
            textfone.TabIndex = 8;
            // 
            // textemail
            // 
            textemail.Location = new Point(335, 161);
            textemail.Name = "textemail";
            textemail.Size = new Size(266, 23);
            textemail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 167);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "Fone :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.o_email__1_;
            pictureBox1.Location = new Point(256, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(btn_Salvar);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textemail);
            groupBox1.Controls.Add(textfone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textCNPJ);
            groupBox1.Controls.Add(textendereco);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textnome);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 240);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Fornecedor";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.telefone;
            pictureBox5.Location = new Point(14, 162);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Salvar.Location = new Point(539, 211);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(75, 23);
            btn_Salvar.TabIndex = 16;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.perfil_de_usuario;
            pictureBox4.Location = new Point(14, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.predio_comercial__1_;
            pictureBox3.Location = new Point(14, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = Properties.Resources.localizacao;
            pictureBox2.Location = new Point(14, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AccessibleName = "dgvFornecedor";
            dgvFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedor.BackgroundColor = Color.Snow;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { Nome, Email, Fone, Endereco, CNPJ });
            dgvFornecedor.Location = new Point(12, 269);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.RowTemplate.Height = 25;
            dgvFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedor.Size = new Size(643, 141);
            dgvFornecedor.TabIndex = 13;
            dgvFornecedor.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Fone
            // 
            Fone.DataPropertyName = "fone";
            Fone.HeaderText = "Fone";
            Fone.Name = "Fone";
            // 
            // Endereco
            // 
            Endereco.DataPropertyName = "endereco";
            Endereco.HeaderText = "Endereço";
            Endereco.Name = "Endereco";
            // 
            // CNPJ
            // 
            CNPJ.DataPropertyName = "cnpj";
            CNPJ.HeaderText = "CNPJ";
            CNPJ.Name = "CNPJ";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAtualizar.Location = new Point(433, 416);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Location = new Point(551, 416);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(75, 23);
            btn_Excluir.TabIndex = 17;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(663, 455);
            Controls.Add(btn_Excluir);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvFornecedor);
            Controls.Add(groupBox1);
            Name = "FormFornecedor";
            Text = "Fornecedor";
            Load += FormFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox textnome;
        private Label label2;
        private Label label3;
        private TextBox textendereco;
        private TextBox textCNPJ;
        private Label label4;
        private TextBox textfone;
        private TextBox textemail;
        private Label label5;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridView dgvFornecedor;
        private Button btnAtualizar;
        private Button btn_Salvar;
        private Button btn_Excluir;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Fone;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn CNPJ;
    }
}