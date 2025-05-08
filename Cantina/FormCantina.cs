using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cantina
{
    public partial class FormCantina : Form
    {
        List<Produto> produtosDisponiveis = new List<Produto>();
        List<Produto> carrinho = new List<Produto>();
        decimal totalPedido = 0;

        public FormCantina()
        {
            InitializeComponent();
        }

        private void FormCantina_Load(object sender, EventArgs e)
        {
            InicializarProdutos();
            AtualizarListaProdutos();
            AtualizarTotal();
        }

        private void InicializarProdutos()
        {
            produtosDisponiveis.Add(new Produto("Coxinha", 5.00m));
            produtosDisponiveis.Add(new Produto("Pastel", 6.00m));
            produtosDisponiveis.Add(new Produto("Refrigerante", 4.50m));
            produtosDisponiveis.Add(new Produto("Suco", 3.00m));
            produtosDisponiveis.Add(new Produto("Brigadeiro", 2.00m));
        }

        private void AtualizarListaProdutos()
        {
            listBoxProdutos.Items.Clear();
            foreach (var produto in produtosDisponiveis)
            {
                listBoxProdutos.Items.Add(produto);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)listBoxProdutos.SelectedItem;
                carrinho.Add(produtoSelecionado);
                listBoxCarrinho.Items.Add(produtoSelecionado);

                totalPedido += produtoSelecionado.Preco;
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Selecione um produto para adicionar ao carrinho!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxCarrinho.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)listBoxCarrinho.SelectedItem;
                carrinho.Remove(produtoSelecionado);
                listBoxCarrinho.Items.Remove(produtoSelecionado);

                totalPedido -= produtoSelecionado.Preco;
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover do carrinho!");
            }
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio!");
                return;
            }

            MessageBox.Show($"Valor total do pedido: R${totalPedido:F2}", "Pedido Finalizado");

            carrinho.Clear();
            listBoxCarrinho.Items.Clear();
            totalPedido = 0;
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            lblTotal.Text = $"Total: R${totalPedido:F2}";
        }
    }
}
