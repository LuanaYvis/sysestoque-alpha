namespace sysestoque_alpha
{
    partial class FormProdutos
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
            groupBox1 = new GroupBox();
            botaomenos = new Button();
            butaomais = new Button();
            mintext = new Label();
            maxtext = new Label();
            textBox5estoquemin = new TextBox();
            textBox4estoquemax = new TextBox();
            textBox3unidade = new TextBox();
            textBox2id = new TextBox();
            comboBox1categotia = new ComboBox();
            textBox1name = new TextBox();
            idtext = new Label();
            unidademedidatext = new Label();
            categoriatext = new Label();
            estoquetext = new Label();
            nometext = new Label();
            teladedados = new DataGridView();
            salvarbotao = new Button();
            excluirbotao = new Button();
            atualizarbotao = new Button();
            incluirbotao = new Button();
            IDproduto = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            EstoqueCat = new DataGridViewTextBoxColumn();
            EstoqueMax = new DataGridViewTextBoxColumn();
            EstoqueMin = new DataGridViewTextBoxColumn();
            UnidadedemedidaProduto = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teladedados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(botaomenos);
            groupBox1.Controls.Add(butaomais);
            groupBox1.Controls.Add(mintext);
            groupBox1.Controls.Add(maxtext);
            groupBox1.Controls.Add(textBox5estoquemin);
            groupBox1.Controls.Add(textBox4estoquemax);
            groupBox1.Controls.Add(textBox3unidade);
            groupBox1.Controls.Add(textBox2id);
            groupBox1.Controls.Add(comboBox1categotia);
            groupBox1.Controls.Add(textBox1name);
            groupBox1.Controls.Add(idtext);
            groupBox1.Controls.Add(unidademedidatext);
            groupBox1.Controls.Add(categoriatext);
            groupBox1.Controls.Add(estoquetext);
            groupBox1.Controls.Add(nometext);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro do Produto";
            // 
            // botaomenos
            // 
            botaomenos.BackColor = Color.LightBlue;
            botaomenos.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            botaomenos.Location = new Point(195, 158);
            botaomenos.Name = "botaomenos";
            botaomenos.Size = new Size(26, 22);
            botaomenos.TabIndex = 14;
            botaomenos.Text = "➖";
            botaomenos.UseVisualStyleBackColor = false;
            // 
            // butaomais
            // 
            butaomais.BackColor = Color.LightBlue;
            butaomais.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            butaomais.Location = new Point(84, 158);
            butaomais.Name = "butaomais";
            butaomais.Size = new Size(26, 22);
            butaomais.TabIndex = 6;
            butaomais.Text = "➕";
            butaomais.UseVisualStyleBackColor = false;
            // 
            // mintext
            // 
            mintext.AutoSize = true;
            mintext.Location = new Point(239, 139);
            mintext.Name = "mintext";
            mintext.Size = new Size(31, 15);
            mintext.TabIndex = 13;
            mintext.Text = "Min.";
            // 
            // maxtext
            // 
            maxtext.AutoSize = true;
            maxtext.Location = new Point(133, 139);
            maxtext.Name = "maxtext";
            maxtext.Size = new Size(33, 15);
            maxtext.TabIndex = 12;
            maxtext.Text = "Max.";
            // 
            // textBox5estoquemin
            // 
            textBox5estoquemin.Location = new Point(227, 157);
            textBox5estoquemin.Name = "textBox5estoquemin";
            textBox5estoquemin.Size = new Size(56, 23);
            textBox5estoquemin.TabIndex = 11;
            // 
            // textBox4estoquemax
            // 
            textBox4estoquemax.Location = new Point(119, 157);
            textBox4estoquemax.Name = "textBox4estoquemax";
            textBox4estoquemax.Size = new Size(56, 23);
            textBox4estoquemax.TabIndex = 10;
            // 
            // textBox3unidade
            // 
            textBox3unidade.Location = new Point(541, 154);
            textBox3unidade.Name = "textBox3unidade";
            textBox3unidade.Size = new Size(131, 23);
            textBox3unidade.TabIndex = 9;
            // 
            // textBox2id
            // 
            textBox2id.Location = new Point(448, 31);
            textBox2id.Name = "textBox2id";
            textBox2id.Size = new Size(135, 23);
            textBox2id.TabIndex = 8;
            // 
            // comboBox1categotia
            // 
            comboBox1categotia.FormattingEnabled = true;
            comboBox1categotia.Location = new Point(87, 95);
            comboBox1categotia.Name = "comboBox1categotia";
            comboBox1categotia.Size = new Size(225, 23);
            comboBox1categotia.TabIndex = 7;
            comboBox1categotia.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1name
            // 
            textBox1name.Location = new Point(84, 40);
            textBox1name.Name = "textBox1name";
            textBox1name.Size = new Size(265, 23);
            textBox1name.TabIndex = 6;
            // 
            // idtext
            // 
            idtext.AutoSize = true;
            idtext.Location = new Point(421, 34);
            idtext.Name = "idtext";
            idtext.Size = new Size(21, 15);
            idtext.TabIndex = 5;
            idtext.Text = "ID:";
            // 
            // unidademedidatext
            // 
            unidademedidatext.AutoSize = true;
            unidademedidatext.Location = new Point(421, 160);
            unidademedidatext.Name = "unidademedidatext";
            unidademedidatext.Size = new Size(113, 15);
            unidademedidatext.TabIndex = 4;
            unidademedidatext.Text = "Unidade de medida:";
            // 
            // categoriatext
            // 
            categoriatext.AutoSize = true;
            categoriatext.Location = new Point(20, 98);
            categoriatext.Name = "categoriatext";
            categoriatext.Size = new Size(61, 15);
            categoriatext.TabIndex = 3;
            categoriatext.Text = "Categoria:";
            categoriatext.Click += label4_Click;
            // 
            // estoquetext
            // 
            estoquetext.AutoSize = true;
            estoquetext.Location = new Point(20, 157);
            estoquetext.Name = "estoquetext";
            estoquetext.Size = new Size(52, 15);
            estoquetext.TabIndex = 2;
            estoquetext.Text = "Estoque:";
            estoquetext.Click += label3_Click;
            // 
            // nometext
            // 
            nometext.AutoSize = true;
            nometext.Location = new Point(20, 43);
            nometext.Name = "nometext";
            nometext.Size = new Size(43, 15);
            nometext.TabIndex = 1;
            nometext.Text = "Nome:";
            // 
            // teladedados
            // 
            teladedados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teladedados.BackgroundColor = Color.Snow;
            teladedados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teladedados.Columns.AddRange(new DataGridViewColumn[] { IDproduto, NomeProduto, EstoqueCat, EstoqueMax, EstoqueMin, UnidadedemedidaProduto });
            teladedados.Location = new Point(12, 228);
            teladedados.Name = "teladedados";
            teladedados.RowTemplate.Height = 25;
            teladedados.Size = new Size(776, 181);
            teladedados.TabIndex = 1;
            teladedados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // salvarbotao
            // 
            salvarbotao.BackColor = Color.Transparent;
            salvarbotao.Location = new Point(447, 415);
            salvarbotao.Name = "salvarbotao";
            salvarbotao.Size = new Size(75, 23);
            salvarbotao.TabIndex = 2;
            salvarbotao.Text = "Salvar";
            salvarbotao.UseVisualStyleBackColor = false;
            salvarbotao.Click += button1_Click;
            // 
            // excluirbotao
            // 
            excluirbotao.Location = new Point(528, 415);
            excluirbotao.Name = "excluirbotao";
            excluirbotao.Size = new Size(75, 23);
            excluirbotao.TabIndex = 3;
            excluirbotao.Text = "Excluir";
            excluirbotao.UseVisualStyleBackColor = true;
            // 
            // atualizarbotao
            // 
            atualizarbotao.Location = new Point(609, 415);
            atualizarbotao.Name = "atualizarbotao";
            atualizarbotao.Size = new Size(75, 23);
            atualizarbotao.TabIndex = 4;
            atualizarbotao.Text = "Atualizar";
            atualizarbotao.UseVisualStyleBackColor = true;
            // 
            // incluirbotao
            // 
            incluirbotao.Location = new Point(690, 415);
            incluirbotao.Name = "incluirbotao";
            incluirbotao.Size = new Size(75, 23);
            incluirbotao.TabIndex = 5;
            incluirbotao.Text = "Incluir";
            incluirbotao.UseVisualStyleBackColor = true;
            // 
            // IDproduto
            // 
            IDproduto.DataPropertyName = "ID";
            IDproduto.HeaderText = "ID";
            IDproduto.Name = "IDproduto";
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "Nome";
            NomeProduto.HeaderText = "Nome";
            NomeProduto.Name = "NomeProduto";
            // 
            // EstoqueCat
            // 
            EstoqueCat.DataPropertyName = "CategoriaId";
            EstoqueCat.HeaderText = "Categoria";
            EstoqueCat.Name = "EstoqueCat";
            // 
            // EstoqueMax
            // 
            EstoqueMax.DataPropertyName = "EstoqueMax";
            EstoqueMax.HeaderText = "  Máximo";
            EstoqueMax.Name = "EstoqueMax";
            // 
            // EstoqueMin
            // 
            EstoqueMin.DataPropertyName = "EstoquiMin";
            EstoqueMin.HeaderText = "Mínimo";
            EstoqueMin.Name = "EstoqueMin";
            // 
            // UnidadedemedidaProduto
            // 
            UnidadedemedidaProduto.DataPropertyName = "unidadeMedida";
            UnidadedemedidaProduto.HeaderText = "Unidade de Medida";
            UnidadedemedidaProduto.Name = "UnidadedemedidaProduto";
            // 
            // produtocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(incluirbotao);
            Controls.Add(atualizarbotao);
            Controls.Add(excluirbotao);
            Controls.Add(salvarbotao);
            Controls.Add(teladedados);
            Controls.Add(groupBox1);
            Name = "produtocs";
            Text = "Produtos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teladedados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label unidademedidatext;
        private Label categoriatext;
        private Label estoquetext;
        private Label nometext;
        private Label idtext;
        private TextBox textBox2id;
        private ComboBox comboBox1categotia;
        private TextBox textBox1name;
        private Label mintext;
        private Label maxtext;
        private TextBox textBox5estoquemin;
        private TextBox textBox4estoquemax;
        private TextBox textBox3unidade;
        private DataGridView teladedados;
        private Button salvarbotao;
        private Button excluirbotao;
        private Button atualizarbotao;
        private Button incluirbotao;
        private Button butaomais;
        private Button botaomenos;
        private DataGridViewTextBoxColumn IDproduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn EstoqueCat;
        private DataGridViewTextBoxColumn EstoqueMax;
        private DataGridViewTextBoxColumn EstoqueMin;
        private DataGridViewTextBoxColumn UnidadedemedidaProduto;
    }
}