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
            mintext = new Label();
            maxtext = new Label();
            textBox5estoquemin = new TextBox();
            textBox4estoquemax = new TextBox();
            textBox3unidade = new TextBox();
            textBox2id = new TextBox();
            comboxcategoria = new ComboBox();
            barratext = new TextBox();
            idtext = new Label();
            unidademedidatext = new Label();
            categoriatext = new Label();
            estoquetext = new Label();
            nometext = new Label();
            teladedadosprod = new DataGridView();
            IDproduto = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            EstoqueCat = new DataGridViewTextBoxColumn();
            EstoqueMax = new DataGridViewTextBoxColumn();
            EstoqueMin = new DataGridViewTextBoxColumn();
            UnidadedemedidaProduto = new DataGridViewTextBoxColumn();
            btnSalvar = new Button();
            btnExluir = new Button();
            btnAtualizar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teladedadosprod).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mintext);
            groupBox1.Controls.Add(maxtext);
            groupBox1.Controls.Add(textBox5estoquemin);
            groupBox1.Controls.Add(textBox4estoquemax);
            groupBox1.Controls.Add(textBox3unidade);
            groupBox1.Controls.Add(textBox2id);
            groupBox1.Controls.Add(comboxcategoria);
            groupBox1.Controls.Add(barratext);
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
            // comboxcategoria
            // 
            comboxcategoria.FormattingEnabled = true;
            comboxcategoria.Location = new Point(87, 95);
            comboxcategoria.Name = "comboxcategoria";
            comboxcategoria.Size = new Size(225, 23);
            comboxcategoria.TabIndex = 7;
            comboxcategoria.SelectedIndexChanged += comboxcategoria_SelectedIndexChanged;
            // 
            // barratext
            // 
            barratext.Location = new Point(84, 40);
            barratext.Name = "barratext";
            barratext.Size = new Size(265, 23);
            barratext.TabIndex = 6;
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
            // 
            // estoquetext
            // 
            estoquetext.AutoSize = true;
            estoquetext.Location = new Point(20, 157);
            estoquetext.Name = "estoquetext";
            estoquetext.Size = new Size(52, 15);
            estoquetext.TabIndex = 2;
            estoquetext.Text = "Estoque:";
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
            // teladedadosprod
            // 
            teladedadosprod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teladedadosprod.BackgroundColor = Color.Snow;
            teladedadosprod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teladedadosprod.Columns.AddRange(new DataGridViewColumn[] { IDproduto, NomeProduto, EstoqueCat, EstoqueMax, EstoqueMin, UnidadedemedidaProduto });
            teladedadosprod.Location = new Point(12, 228);
            teladedadosprod.Name = "teladedadosprod";
            teladedadosprod.RowTemplate.Height = 25;
            teladedadosprod.Size = new Size(776, 181);
            teladedadosprod.TabIndex = 1;
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
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Location = new Point(500, 415);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExluir
            // 
            btnExluir.Location = new Point(599, 415);
            btnExluir.Name = "btnExluir";
            btnExluir.Size = new Size(75, 23);
            btnExluir.TabIndex = 3;
            btnExluir.Text = "Excluir";
            btnExluir.UseVisualStyleBackColor = true;
            btnExluir.Click += btnExluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(692, 415);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExluir);
            Controls.Add(btnSalvar);
            Controls.Add(teladedadosprod);
            Controls.Add(groupBox1);
            Name = "FormProdutos";
            Text = "Produtos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teladedadosprod).EndInit();
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
        private ComboBox comboxcategoria;
        private TextBox barratext;
        private Label mintext;
        private Label maxtext;
        private TextBox textBox5estoquemin;
        private TextBox textBox4estoquemax;
        private TextBox textBox3unidade;
        private DataGridView teladedadosprod;
        private Button btnSalvar;
        private Button btnExluir;
        private Button btnAtualizar;
        private DataGridViewTextBoxColumn IDproduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn EstoqueCat;
        private DataGridViewTextBoxColumn EstoqueMax;
        private DataGridViewTextBoxColumn EstoqueMin;
        private DataGridViewTextBoxColumn UnidadedemedidaProduto;
    }
}