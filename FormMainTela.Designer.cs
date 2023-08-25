namespace sysestoque_alpha
{
    partial class FormMainTela
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
            menuStrip1 = new MenuStrip();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            adicionarNovoProdutoToolStripMenuItem = new ToolStripMenuItem();
            configurarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            adicionarFonToolStripMenuItem = new ToolStripMenuItem();
            configurarFornercedorToolStripMenuItem = new ToolStripMenuItem();
            notaDeEntradaToolStripMenuItem = new ToolStripMenuItem();
            adicionarNotaDeEntradaToolStripMenuItem = new ToolStripMenuItem();
            notaDeSaídaToolStripMenuItem = new ToolStripMenuItem();
            adicionarNotaDeSaídaToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusLabelMsgPrincipal = new ToolStripStatusLabel();
            dgvsis = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            EstoqueMax = new DataGridViewTextBoxColumn();
            Estoquemedio = new DataGridViewTextBoxColumn();
            EstoqueMin = new DataGridViewTextBoxColumn();
            UniMed = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtestmi = new TextBox();
            label2 = new Label();
            txtEstma = new TextBox();
            label3 = new Label();
            txtestme = new TextBox();
            informaçãoToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem1 = new ToolStripMenuItem();
            configurarUnidadeDeMedidaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsis).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, fornecedorToolStripMenuItem, notaDeEntradaToolStripMenuItem, notaDeSaídaToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarNovoProdutoToolStripMenuItem, configurarCategoriaToolStripMenuItem, configurarUnidadeDeMedidaToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarNovoProdutoToolStripMenuItem
            // 
            adicionarNovoProdutoToolStripMenuItem.Name = "adicionarNovoProdutoToolStripMenuItem";
            adicionarNovoProdutoToolStripMenuItem.Size = new Size(203, 22);
            adicionarNovoProdutoToolStripMenuItem.Text = "Adicionar Novo Produto";
            // 
            // configurarCategoriaToolStripMenuItem
            // 
            configurarCategoriaToolStripMenuItem.Name = "configurarCategoriaToolStripMenuItem";
            configurarCategoriaToolStripMenuItem.Size = new Size(203, 22);
            configurarCategoriaToolStripMenuItem.Text = "Configurar Categoria";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarFonToolStripMenuItem, configurarFornercedorToolStripMenuItem });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(79, 20);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // adicionarFonToolStripMenuItem
            // 
            adicionarFonToolStripMenuItem.Name = "adicionarFonToolStripMenuItem";
            adicionarFonToolStripMenuItem.Size = new Size(198, 22);
            adicionarFonToolStripMenuItem.Text = "Adicionar Fornecedor";
            adicionarFonToolStripMenuItem.Click += adicionarFonToolStripMenuItem_Click;
            // 
            // configurarFornercedorToolStripMenuItem
            // 
            configurarFornercedorToolStripMenuItem.Name = "configurarFornercedorToolStripMenuItem";
            configurarFornercedorToolStripMenuItem.Size = new Size(198, 22);
            configurarFornercedorToolStripMenuItem.Text = "Configurar Fornercedor";
            // 
            // notaDeEntradaToolStripMenuItem
            // 
            notaDeEntradaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarNotaDeEntradaToolStripMenuItem });
            notaDeEntradaToolStripMenuItem.Name = "notaDeEntradaToolStripMenuItem";
            notaDeEntradaToolStripMenuItem.Size = new Size(104, 20);
            notaDeEntradaToolStripMenuItem.Text = "Nota de Entrada";
            // 
            // adicionarNotaDeEntradaToolStripMenuItem
            // 
            adicionarNotaDeEntradaToolStripMenuItem.Name = "adicionarNotaDeEntradaToolStripMenuItem";
            adicionarNotaDeEntradaToolStripMenuItem.Size = new Size(219, 22);
            adicionarNotaDeEntradaToolStripMenuItem.Text = "Adicionar Nota de Entrada";
            adicionarNotaDeEntradaToolStripMenuItem.Click += adicionarNotaDeEntradaToolStripMenuItem_Click;
            // 
            // notaDeSaídaToolStripMenuItem
            // 
            notaDeSaídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarNotaDeSaídaToolStripMenuItem });
            notaDeSaídaToolStripMenuItem.Name = "notaDeSaídaToolStripMenuItem";
            notaDeSaídaToolStripMenuItem.Size = new Size(92, 20);
            notaDeSaídaToolStripMenuItem.Text = "Nota de Saída";
            // 
            // adicionarNotaDeSaídaToolStripMenuItem
            // 
            adicionarNotaDeSaídaToolStripMenuItem.Name = "adicionarNotaDeSaídaToolStripMenuItem";
            adicionarNotaDeSaídaToolStripMenuItem.Size = new Size(207, 22);
            adicionarNotaDeSaídaToolStripMenuItem.Text = "Adicionar Nota de Saída";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informaçãoToolStripMenuItem, ajudaToolStripMenuItem1 });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusLabelMsgPrincipal });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(69, 17);
            toolStripStatusLabel1.Text = "Mensagem:";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // statusLabelMsgPrincipal
            // 
            statusLabelMsgPrincipal.AutoSize = false;
            statusLabelMsgPrincipal.Name = "statusLabelMsgPrincipal";
            statusLabelMsgPrincipal.Size = new Size(300, 17);
            // 
            // dgvsis
            // 
            dgvsis.AllowUserToAddRows = false;
            dgvsis.AllowUserToDeleteRows = false;
            dgvsis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsis.BackgroundColor = SystemColors.Window;
            dgvsis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsis.Columns.AddRange(new DataGridViewColumn[] { Id, Categoria, EstoqueMax, Estoquemedio, EstoqueMin, UniMed });
            dgvsis.GridColor = SystemColors.Window;
            dgvsis.Location = new Point(12, 39);
            dgvsis.Name = "dgvsis";
            dgvsis.ReadOnly = true;
            dgvsis.RowTemplate.Height = 25;
            dgvsis.Size = new Size(776, 240);
            dgvsis.TabIndex = 2;
            dgvsis.CellContentClick += dgvsis_CellContentClick;
            dgvsis.Click += dgvsis_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria.Nome";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // EstoqueMax
            // 
            EstoqueMax.DataPropertyName = "EstoqueMax";
            EstoqueMax.HeaderText = "Estoque Máximo";
            EstoqueMax.Name = "EstoqueMax";
            EstoqueMax.ReadOnly = true;
            // 
            // Estoquemedio
            // 
            Estoquemedio.DataPropertyName = "EstoqueMedio";
            Estoquemedio.HeaderText = "Estoque de Médio";
            Estoquemedio.Name = "Estoquemedio";
            Estoquemedio.ReadOnly = true;
            // 
            // EstoqueMin
            // 
            EstoqueMin.DataPropertyName = "EstoqueMin";
            EstoqueMin.HeaderText = "Estoque Mínimo";
            EstoqueMin.Name = "EstoqueMin";
            EstoqueMin.ReadOnly = true;
            // 
            // UniMed
            // 
            UniMed.DataPropertyName = "UnidadeMedida.Nome";
            UniMed.HeaderText = "Unidade de Media";
            UniMed.Name = "UniMed";
            UniMed.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 308);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Estoque mínimo:";
            // 
            // txtestmi
            // 
            txtestmi.BackColor = SystemColors.Window;
            txtestmi.Enabled = false;
            txtestmi.ForeColor = SystemColors.Window;
            txtestmi.Location = new Point(131, 305);
            txtestmi.Name = "txtestmi";
            txtestmi.Size = new Size(142, 23);
            txtestmi.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 308);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Estoque máximo:";
            // 
            // txtEstma
            // 
            txtEstma.BackColor = SystemColors.Window;
            txtEstma.Enabled = false;
            txtEstma.Location = new Point(414, 305);
            txtEstma.Name = "txtEstma";
            txtEstma.Size = new Size(142, 23);
            txtEstma.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 377);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Estoque médio:";
            // 
            // txtestme
            // 
            txtestme.BackColor = SystemColors.Window;
            txtestme.Enabled = false;
            txtestme.ForeColor = SystemColors.Window;
            txtestme.Location = new Point(131, 374);
            txtestme.Name = "txtestme";
            txtestme.Size = new Size(142, 23);
            txtestme.TabIndex = 8;
            // 
            // informaçãoToolStripMenuItem
            // 
            informaçãoToolStripMenuItem.Name = "informaçãoToolStripMenuItem";
            informaçãoToolStripMenuItem.Size = new Size(180, 22);
            informaçãoToolStripMenuItem.Text = "Informação";
            // 
            // ajudaToolStripMenuItem1
            // 
            ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            ajudaToolStripMenuItem1.Size = new Size(180, 22);
            ajudaToolStripMenuItem1.Text = "Ajuda";
            // 
            // configurarUnidadeDeMedidaToolStripMenuItem
            // 
            configurarUnidadeDeMedidaToolStripMenuItem.Name = "configurarUnidadeDeMedidaToolStripMenuItem";
            configurarUnidadeDeMedidaToolStripMenuItem.Size = new Size(237, 22);
            configurarUnidadeDeMedidaToolStripMenuItem.Text = "Configurar Unidade de Medida";
            // 
            // FormMainTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtestme);
            Controls.Add(label3);
            Controls.Add(txtEstma);
            Controls.Add(label2);
            Controls.Add(txtestmi);
            Controls.Add(label1);
            Controls.Add(dgvsis);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMainTela";
            Text = "Sistema Alfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem adicionarNovoProdutoToolStripMenuItem;
        private ToolStripMenuItem configurarCategoriaToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem adicionarFonToolStripMenuItem;
        private ToolStripMenuItem notaDeEntradaToolStripMenuItem;
        private ToolStripMenuItem notaDeSaídaToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusLabelMsgPrincipal;
        private DataGridView dgvsis;
        private Label label1;
        private TextBox txtestmi;
        private Label label2;
        private TextBox txtEstma;
        private Label label3;
        private TextBox txtestme;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn EstoqueMax;
        private DataGridViewTextBoxColumn Estoquemedio;
        private DataGridViewTextBoxColumn EstoqueMin;
        private DataGridViewTextBoxColumn UniMed;
        private ToolStripMenuItem configurarFornercedorToolStripMenuItem;
        private ToolStripMenuItem adicionarNotaDeEntradaToolStripMenuItem;
        private ToolStripMenuItem adicionarNotaDeSaídaToolStripMenuItem;
        private ToolStripMenuItem informaçãoToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem1;
        private ToolStripMenuItem configurarUnidadeDeMedidaToolStripMenuItem;
    }
}