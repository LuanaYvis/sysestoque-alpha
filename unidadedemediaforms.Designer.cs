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
            ID = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Cadastro
            // 
            Cadastro.Controls.Add(textBox2);
            Cadastro.Controls.Add(button4);
            Cadastro.Controls.Add(button3);
            Cadastro.Controls.Add(comboBox1);
            Cadastro.Controls.Add(button2);
            Cadastro.Controls.Add(button1);
            Cadastro.Controls.Add(dataGridView1);
            Cadastro.Controls.Add(textBox1);
            Cadastro.Controls.Add(label2);
            Cadastro.Controls.Add(label1);
            Cadastro.Controls.Add(ID);
            Cadastro.Location = new Point(12, 12);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(776, 426);
            Cadastro.TabIndex = 0;
            Cadastro.TabStop = false;
            Cadastro.Text = "Cadastro Unidade de Medida";
            Cadastro.Enter += groupBox1_Enter;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Transparent;
            ID.Location = new Point(29, 73);
            ID.Name = "ID";
            ID.Size = new Size(21, 15);
            ID.TabIndex = 0;
            ID.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(29, 154);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(29, 232);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 2;
            label2.Text = "Unidade de Medida:";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 385);
            dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(216, 381);
            button1.Name = "button1";
            button1.Size = new Size(93, 26);
            button1.TabIndex = 7;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(315, 381);
            button2.Name = "button2";
            button2.Size = new Size(93, 26);
            button2.TabIndex = 8;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(112, 381);
            button3.Name = "button3";
            button3.Size = new Size(93, 26);
            button3.TabIndex = 10;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 381);
            button4.Name = "button4";
            button4.Size = new Size(93, 26);
            button4.TabIndex = 11;
            button4.Text = "Salvar";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 12;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Cadastro;
        private Label ID;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
    }
}