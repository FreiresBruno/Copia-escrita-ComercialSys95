namespace ComercialSys
{
    partial class FrmPedido
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            txtNumeroPedido = new TextBox();
            label3 = new Label();
            txtVendedor = new TextBox();
            btnAbrirNovo = new Button();
            gbxProduto = new GroupBox();
            btnInserirItem = new Button();
            lblDescMax = new Label();
            label7 = new Label();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label6 = new Label();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnUnitVenda = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantdade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnValorItem = new DataGridViewTextBoxColumn();
            clnid = new DataGridViewTextBoxColumn();
            btnFechar = new Button();
            txtDesconto = new TextBox();
            txtOutros = new TextBox();
            txtTotal = new TextBox();
            txtSubTotal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnExcluirItem = new Button();
            groupBox1.SuspendLayout();
            gbxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "Pedido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(35, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 97);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(415, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(793, 43);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 24F);
            txtNumeroPedido.ForeColor = Color.Red;
            txtNumeroPedido.Location = new Point(793, 61);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(169, 50);
            txtNumeroPedido.TabIndex = 3;
            txtNumeroPedido.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 61);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(99, 58);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(346, 23);
            txtVendedor.TabIndex = 5;
            // 
            // btnAbrirNovo
            // 
            btnAbrirNovo.Location = new Point(630, 151);
            btnAbrirNovo.Name = "btnAbrirNovo";
            btnAbrirNovo.Size = new Size(145, 44);
            btnAbrirNovo.TabIndex = 6;
            btnAbrirNovo.Text = "&Abrir Pedido";
            btnAbrirNovo.UseVisualStyleBackColor = true;
            btnAbrirNovo.Click += btnAbrirNovo_Click;
            // 
            // gbxProduto
            // 
            gbxProduto.Controls.Add(btnInserirItem);
            gbxProduto.Controls.Add(lblDescMax);
            gbxProduto.Controls.Add(label7);
            gbxProduto.Controls.Add(txtQuantidade);
            gbxProduto.Controls.Add(txtValorUnit);
            gbxProduto.Controls.Add(label6);
            gbxProduto.Controls.Add(txtDescricao);
            gbxProduto.Controls.Add(txtCodBar);
            gbxProduto.Controls.Add(label5);
            gbxProduto.Controls.Add(label4);
            gbxProduto.Enabled = false;
            gbxProduto.Location = new Point(36, 201);
            gbxProduto.Name = "gbxProduto";
            gbxProduto.Size = new Size(739, 82);
            gbxProduto.TabIndex = 7;
            gbxProduto.TabStop = false;
            gbxProduto.Text = "Produto";
            // 
            // btnInserirItem
            // 
            btnInserirItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserirItem.Location = new Point(658, 28);
            btnInserirItem.Name = "btnInserirItem";
            btnInserirItem.Size = new Size(75, 35);
            btnInserirItem.TabIndex = 8;
            btnInserirItem.Text = "Inserir";
            btnInserirItem.UseVisualStyleBackColor = true;
            btnInserirItem.Click += btnInserirItem_Click;
            // 
            // lblDescMax
            // 
            lblDescMax.AutoSize = true;
            lblDescMax.ForeColor = Color.Red;
            lblDescMax.Location = new Point(552, 63);
            lblDescMax.Name = "lblDescMax";
            lblDescMax.Size = new Size(50, 15);
            lblDescMax.TabIndex = 7;
            lblDescMax.Text = "R$ 00,00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 19);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 7;
            label7.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(552, 37);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 6;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(446, 37);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, 19);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 4;
            label6.Text = "Valor Unitário";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(121, 37);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(319, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(6, 37);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(100, 23);
            txtCodBar.TabIndex = 2;
            txtCodBar.TextChanged += txtCodBar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 19);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 1;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 0;
            label4.Text = "Código de Barras";
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnUnitVenda, clnValorUnit, clnQuantdade, clnDesconto, clnValorItem, clnid });
            dgvItensPedido.Location = new Point(36, 307);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPedido.Size = new Size(739, 268);
            dgvItensPedido.TabIndex = 8;
            dgvItensPedido.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "Seq";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "CodBar";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnUnitVenda
            // 
            clnUnitVenda.Frozen = true;
            clnUnitVenda.HeaderText = "Unidade";
            clnUnitVenda.Name = "clnUnitVenda";
            clnUnitVenda.ReadOnly = true;
            clnUnitVenda.Width = 60;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            // 
            // clnQuantdade
            // 
            clnQuantdade.HeaderText = "Quantidade";
            clnQuantdade.Name = "clnQuantdade";
            clnQuantdade.ReadOnly = true;
            clnQuantdade.Width = 70;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnValorItem
            // 
            clnValorItem.HeaderText = "Valor Item";
            clnValorItem.Name = "clnValorItem";
            clnValorItem.ReadOnly = true;
            // 
            // clnid
            // 
            clnid.HeaderText = "id";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Visible = false;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 14F);
            btnFechar.Location = new Point(793, 543);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(169, 41);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Finalizar Pedido";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(795, 367);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(119, 23);
            txtDesconto.TabIndex = 10;
            // 
            // txtOutros
            // 
            txtOutros.Location = new Point(796, 412);
            txtOutros.Name = "txtOutros";
            txtOutros.Size = new Size(118, 23);
            txtOutros.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(793, 456);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(167, 39);
            txtTotal.TabIndex = 12;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(795, 307);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(167, 39);
            txtSubTotal.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(795, 289);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 14;
            label8.Text = "Sub-Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(795, 349);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 15;
            label9.Text = "Desconto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(796, 394);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 16;
            label10.Text = "Outros";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(795, 438);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 17;
            label11.Text = "Total";
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Location = new Point(793, 497);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(166, 40);
            btnExcluirItem.TabIndex = 18;
            btnExcluirItem.Text = "Excluir Item";
            btnExcluirItem.UseVisualStyleBackColor = true;
            btnExcluirItem.Click += btnExcluirItem_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 587);
            Controls.Add(btnExcluirItem);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtSubTotal);
            Controls.Add(txtTotal);
            Controls.Add(txtOutros);
            Controls.Add(txtDesconto);
            Controls.Add(btnFechar);
            Controls.Add(dgvItensPedido);
            Controls.Add(gbxProduto);
            Controls.Add(btnAbrirNovo);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(txtNumeroPedido);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxProduto.ResumeLayout(false);
            gbxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNumeroPedido;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrirNovo;
        private GroupBox gbxProduto;
        private DataGridView dgvItensPedido;
        private Button btnFechar;
        private TextBox txtDesconto;
        private TextBox txtOutros;
        private TextBox txtTotal;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtDescricao;
        private TextBox txtCodBar;
        private Label label5;
        private Label label4;
        private Button btnInserirItem;
        private Label label7;
        private TextBox txtQuantidade;
        private TextBox txtSubTotal;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblDescMax;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnUnitVenda;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantdade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnValorItem;
        private DataGridViewTextBoxColumn clnid;
        private Button btnExcluirItem;
    }
}