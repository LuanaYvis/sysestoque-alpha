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
            cbxUM = new ComboBox();
            tbxNome = new TextBox();
            mintext = new Label();
            maxtext = new Label();
            txbmin = new TextBox();
            txbmax = new TextBox();
            barratexid = new TextBox();
            cbxcat = new ComboBox();
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
            groupBox1.Controls.Add(cbxUM);
            groupBox1.Controls.Add(tbxNome);
            groupBox1.Controls.Add(mintext);
            groupBox1.Controls.Add(maxtext);
            groupBox1.Controls.Add(txbmin);
            groupBox1.Controls.Add(txbmax);
            groupBox1.Controls.Add(barratexid);
            groupBox1.Controls.Add(cbxcat);
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
            // cbxUM
            // 
            cbxUM.FormattingEnabled = true;
            cbxUM.Location = new Point(523, 100);
            cbxUM.Name = "cbxUM";
            cbxUM.Size = new Size(156, 23);
            cbxUM.TabIndex = 15;
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(70, 38);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(240, 23);
            tbxNome.TabIndex = 14;
            tbxNome.TextChanged += tbxNome_TextChanged;
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
            // txbmin
            // 
            txbmin.Location = new Point(227, 157);
            txbmin.Name = "txbmin";
            txbmin.Size = new Size(56, 23);
            txbmin.TabIndex = 11;
            // 
            // txbmax
            // 
            txbmax.Location = new Point(119, 157);
            txbmax.Name = "txbmax";
            txbmax.Size = new Size(56, 23);
            txbmax.TabIndex = 10;
            // 
            // barratexid
            // 
            barratexid.Location = new Point(448, 31);
            barratexid.Name = "barratexid";
            barratexid.Size = new Size(135, 23);
            barratexid.TabIndex = 8;
            // 
            // cbxcat
            // 
            cbxcat.FormattingEnabled = true;
            cbxcat.Location = new Point(87, 95);
            cbxcat.Name = "cbxcat";
            cbxcat.Size = new Size(225, 23);
            cbxcat.TabIndex = 7;
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
            unidademedidatext.Location = new Point(395, 103);
            unidademedidatext.Name = "unidademedidatext";
            unidademedidatext.Size = new Size(110, 15);
            unidademedidatext.TabIndex = 4;
            unidademedidatext.Text = "Unidade de medida";
            unidademedidatext.Click += unidademedidatext_Click;
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
            IDproduto.DataPropertyName = "Id";
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
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Location = new Point(503, 415);
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
            Load += FormProdutos_Load;
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
        private TextBox barratexid;
        private ComboBox cbxcat;
        private Label mintext;
        private Label maxtext;
        private TextBox txbmin;
        private TextBox txbmax;
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
        private TextBox tbxNome;
        private ComboBox cbxUM;
    }
}