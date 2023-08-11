namespace sysestoque_alpha
{
    partial class unidadedemediaforms
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
            Cadastro = new GroupBox();
            textBox2 = new TextBox();
            btnSalvar = new Button();
            bntExcluir = new Button();
            comboBox1 = new ComboBox();
            btnAtualizar = new Button();
            teladedadosUM = new DataGridView();
            nomeid = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            descriçaoproduto = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            unidadelabel = new Label();
            nomelabel = new Label();
            Id = new Label();
            Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teladedadosUM).BeginInit();
            SuspendLayout();
            // 
            // Cadastro
            // 
            Cadastro.Controls.Add(textBox2);
            Cadastro.Controls.Add(btnSalvar);
            Cadastro.Controls.Add(bntExcluir);
            Cadastro.Controls.Add(comboBox1);
            Cadastro.Controls.Add(btnAtualizar);
            Cadastro.Controls.Add(teladedadosUM);
            Cadastro.Controls.Add(textBox1);
            Cadastro.Controls.Add(unidadelabel);
            Cadastro.Controls.Add(nomelabel);
            Cadastro.Controls.Add(Id);
            Cadastro.Location = new Point(12, 12);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(776, 426);
            Cadastro.TabIndex = 0;
            Cadastro.TabStop = false;
            Cadastro.Text = "Cadastro Unidade de Medida";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += btnSalvar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(29, 381);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 26);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // bntExcluir
            // 
            bntExcluir.Location = new Point(159, 381);
            bntExcluir.Name = "bntExcluir";
            bntExcluir.Size = new Size(93, 26);
            bntExcluir.TabIndex = 10;
            bntExcluir.Text = "Excluir";
            bntExcluir.UseVisualStyleBackColor = true;
            bntExcluir.Click += bntExcluir_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 9;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(285, 381);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(93, 26);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // teladedadosUM
            // 
            teladedadosUM.BackgroundColor = Color.Snow;
            teladedadosUM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teladedadosUM.Columns.AddRange(new DataGridViewColumn[] { nomeid, NOME, descriçaoproduto });
            teladedadosUM.GridColor = SystemColors.ActiveBorder;
            teladedadosUM.Location = new Point(414, 22);
            teladedadosUM.Name = "teladedadosUM";
            teladedadosUM.RowTemplate.Height = 25;
            teladedadosUM.Size = new Size(344, 385);
            teladedadosUM.TabIndex = 6;
            teladedadosUM.CellContentClick += teladedadosUM_CellContentClick;
            // 
            // nomeid
            // 
            nomeid.DataPropertyName = "id";
            nomeid.HeaderText = "ID";
            nomeid.Name = "nomeid";
            // 
            // NOME
            // 
            NOME.DataPropertyName = "nome";
            NOME.HeaderText = "Nome";
            NOME.Name = "NOME";
            // 
            // descriçaoproduto
            // 
            descriçaoproduto.DataPropertyName = "descricao";
            descriçaoproduto.HeaderText = "Unidade de Medida";
            descriçaoproduto.Name = "descriçaoproduto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 3;
            // 
            // unidadelabel
            // 
            unidadelabel.AutoSize = true;
            unidadelabel.BackColor = Color.Transparent;
            unidadelabel.Location = new Point(29, 232);
            unidadelabel.Name = "unidadelabel";
            unidadelabel.Size = new Size(113, 15);
            unidadelabel.TabIndex = 2;
            unidadelabel.Text = "Unidade de Medida:";
            // 
            // nomelabel
            // 
            nomelabel.AutoSize = true;
            nomelabel.BackColor = Color.Transparent;
            nomelabel.Location = new Point(29, 154);
            nomelabel.Name = "nomelabel";
            nomelabel.Size = new Size(43, 15);
            nomelabel.TabIndex = 1;
            nomelabel.Text = "Nome:";
            nomelabel.Click += label1_Click;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.BackColor = Color.Transparent;
            Id.Location = new Point(29, 73);
            Id.Name = "Id";
            Id.Size = new Size(21, 15);
            Id.TabIndex = 0;
            Id.Text = "ID:";
            // 
            // unidadedemediaforms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastro);
            Name = "unidadedemediaforms";
            Text = "unidadedemediaforms";
            Cadastro.ResumeLayout(false);
            Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teladedadosUM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Cadastro;
        private Label Id;
        private Label unidadelabel;
        private Label nomelabel;
        private Button btnAtualizar;
        private DataGridView teladedadosUM;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button btnSalvar;
        private Button bntExcluir;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn nomeid;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn descriçaoproduto;
    }
}