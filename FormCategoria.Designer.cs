namespace sysestoque_alpha
{
    partial class FormCategoria
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
            dgvCategoria = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            lblID = new Label();
            lblNome = new Label();
            lblDescricao = new Label();
            gpbDadosCategoria = new GroupBox();
            txtID = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            gpbDadosCategoria.SuspendLayout();
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
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToResizeColumns = false;
            dgvCategoria.AllowUserToResizeRows = false;
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoria.BackgroundColor = SystemColors.InactiveCaption;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Column1 });
            dgvCategoria.GridColor = SystemColors.ControlLight;
            dgvCategoria.Location = new Point(12, 225);
            dgvCategoria.MultiSelect = false;
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategoria.RowTemplate.Height = 25;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(776, 174);
            dgvCategoria.TabIndex = 3;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Descricao";
            Column1.HeaderText = "Descrição";
            Column1.Name = "Column1";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(22, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 4;
            lblID.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 84);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(22, 144);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descricão";
            // 
            // gpbDadosCategoria
            // 
            gpbDadosCategoria.Controls.Add(txtID);
            gpbDadosCategoria.Controls.Add(txtDescricao);
            gpbDadosCategoria.Controls.Add(txtNome);
            gpbDadosCategoria.Controls.Add(lblDescricao);
            gpbDadosCategoria.Controls.Add(lblNome);
            gpbDadosCategoria.Controls.Add(lblID);
            gpbDadosCategoria.Location = new Point(12, 1);
            gpbDadosCategoria.Name = "gpbDadosCategoria";
            gpbDadosCategoria.Size = new Size(776, 218);
            gpbDadosCategoria.TabIndex = 8;
            gpbDadosCategoria.TabStop = false;
            gpbDadosCategoria.Text = "Dados de Categoria";
            // 
            // txtID
            // 
            txtID.Location = new Point(81, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(36, 23);
            txtID.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(81, 141);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(145, 23);
            txtDescricao.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(81, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(282, 23);
            txtNome.TabIndex = 0;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(gpbDadosCategoria);
            Controls.Add(dgvCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormCategoria";
            Text = "Categoria";
            Load += Categoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            gpbDadosCategoria.ResumeLayout(false);
            gpbDadosCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnSalvar;
        private DataGridView dgvCategoria;
        private Label lblID;
        private Label lblNome;
        private Label lblDescricao;
        private GroupBox gpbDadosCategoria;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Column1;
        private TextBox txtID;
    }
}