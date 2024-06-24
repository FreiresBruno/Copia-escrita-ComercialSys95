using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = Program.Usuario.Id + " - " + Program.Usuario.Nome;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            if (textBox2.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(textBox2.Text));
                if (cliente.Id > 0)
                {
                    textBox3.Text = cliente.Nome;
                }
            }
        }

        private void btnAbrirNovo_Click(object sender, EventArgs e)
        {
            Pedido pedido = new();
            pedido.Cliente = Cliente.ObterPorId(int.Parse(textBox2.Text));
            pedido.Usuario = Program.Usuario;
            pedido.Status = "A";
            pedido.Desconto = 0;
            pedido.Inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbxProduto.Enabled = true;
            btnAbrirNovo.Enabled = false;

        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 4)
            {
                var produto = Produto.BuscarPorId(int.Parse(txtCodBar.Text));
                if (produto.Id > 0)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtValorUnit.Text = produto.ValorUnit.ToString();

                }


            }
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new(
                int.Parse(txtNumeroPedido.Text)
                , Produto.BuscarPorId(int.Parse(txtCodBar.Text))
                , double.Parse(txtValorUnit.Text)
                , double.Parse(txtQuantidade.Text)
                , double.Parse(txtDesconto.Text)
            );
            itemPedido.Inserir();

            // limpar o datagrid
            dgvItensPedido.Rows.Clear();
            var items = ItemPedido.ObterListaPorPedido(int.Parse(txtNumeroPedido.Text));
            int cont = 0;
            double subTotal = 0;
            foreach (var item in items)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[cont].Cells[0].Value = $"#{cont + 1}";//seq
                dgvItensPedido.Rows[cont].Cells[1].Value = item.Produto.CodBarras;//codbar
                dgvItensPedido.Rows[cont].Cells[2].Value = item.Produto.Descricao;//descrição
                dgvItensPedido.Rows[cont].Cells[3].Value = item.Produto.UnidadeVenda;//unidade venda
                dgvItensPedido.Rows[cont].Cells[4].Value = item.ValorUnit;//valor unitario
                dgvItensPedido.Rows[cont].Cells[5].Value = item.Quantidade;//quantidade
                dgvItensPedido.Rows[cont].Cells[6].Value = item.Desconto;//desconto
                dgvItensPedido.Rows[cont].Cells[7].Value = item.ValorUnit * item.Quantidade - item.Desconto ;//valor
                subTotal += item.ValorUnit * item.Quantidade - item.Desconto;
                cont++;
            }
            txtSubTotal.Text = subTotal.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtOutros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
