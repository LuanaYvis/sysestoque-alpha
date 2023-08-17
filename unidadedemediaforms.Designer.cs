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
            txtnome = new TextBox();
            btnSalvar = new Button();
            bntExcluir = new Button();
            cbxcatUM = new ComboBox();
            btnAtualizar = new Button();
            teladedadosUM = new DataGridView();
            nomeid = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            descriçaoproduto = new DataGridViewTextBoxColumn();
            txtid = new TextBox();
            lblUM = new Label();
            lblnome = new Label();
            Id = new Label();
            Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teladedadosUM).BeginInit();
            SuspendLayout();
            // 
            // Cadastro
            // 
            Cadastro.Controls.Add(txtnome);
            Cadastro.Controls.Add(btnSalvar);
            Cadastro.Controls.Add(bntExcluir);
            Cadastro.Controls.Add(cbxcatUM);
            Cadastro.Controls.Add(btnAtualizar);
            Cadastro.Controls.Add(teladedadosUM);
            Cadastro.Controls.Add(txtid);
            Cadastro.Controls.Add(lblUM);
            Cadastro.Controls.Add(lblnome);
            Cadastro.Controls.Add(Id);
            Cadastro.Location = new Point(12, 12);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(776, 426);
            Cadastro.TabIndex = 0;
            Cadastro.TabStop = false;
            Cadastro.Text = "Cadastro Unidade de Medida";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(88, 151);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(139, 23);
            txtnome.TabIndex = 12;
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
            // cbxcatUM
            // 
            cbxcatUM.FormattingEnabled = true;
            cbxcatUM.Location = new Point(148, 229);
            cbxcatUM.Name = "cbxcatUM";
            cbxcatUM.Size = new Size(159, 23);
            cbxcatUM.TabIndex = 9;
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
            // txtid
            // 
            txtid.Location = new Point(56, 70);
            txtid.Name = "txtid";
            txtid.Size = new Size(139, 23);
            txtid.TabIndex = 3;
            // 
            // lblUM
            // 
            lblUM.AutoSize = true;
            lblUM.BackColor = Color.Transparent;
            lblUM.Location = new Point(29, 232);
            lblUM.Name = "lblUM";
            lblUM.Size = new Size(113, 15);
            lblUM.TabIndex = 2;
            lblUM.Text = "Unidade de Medida:";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.BackColor = Color.Transparent;
            lblnome.Location = new Point(29, 154);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 1;
            lblnome.Text = "Nome";
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
        private Label lblUM;
        private Label lblnome;
        private Button btnAtualizar;
        private DataGridView teladedadosUM;
        private ComboBox cbxcatUM;
        private TextBox txtnome;
        private Button btnSalvar;
        private Button bntExcluir;
        private TextBox txtid;
        private DataGridViewTextBoxColumn nomeid;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn descriçaoproduto;
    }
}