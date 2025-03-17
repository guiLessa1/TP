using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_produto
{
    public partial class Form1: Form
    {
        private ProdutoController controller = new ProdutoController();
        private bool additionalFieldsRendered = false;
        private List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }
        public void AtualizarLista()
        {
            List<Produto> produtos = controller.ObterProdutos();
            dtRelatorio.DataSource = null;
            dtRelatorio.DataSource = produtos;
        }
        public void renderizar()
        {
            Label lbQuantidade = new Label
            {
                Name = "lbQuantidade",
                Text = "Quantidade",
                Location = new System.Drawing.Point(160, 160),
                Size = new System.Drawing.Size(47, 16),
                Width = 65
            };
            this.Controls.Add(lbQuantidade);

            TextBox txQuantidade = new TextBox
            {
                Name = "txQuantidade",
                Location = new System.Drawing.Point(240, 160),
                Size = new System.Drawing.Size(100, 22),
            };
            this.Controls.Add(txQuantidade);

            Label lbDescricao = new Label
            {
                Name = "lbDescricao",
                Text = "Descrição",
                Location = new System.Drawing.Point(160, 195),
                Size = new System.Drawing.Size(47, 16),
            };
            this.Controls.Add(lbDescricao);

            TextBox txDescricao = new TextBox
            {
                Name = "txDescricao",
                Location = new System.Drawing.Point(240, 195),
                Size = new System.Drawing.Size(100, 22),
            };
            this.Controls.Add(txDescricao);

            Button btCadastrar = new Button
            {
                Name = "btCadastrar",
                Text = "Cadastrar",
                Location = new System.Drawing.Point(350, 150),
                Size = new System.Drawing.Size(105, 67)
            };

            btCadastrar.Click += (s, e) =>
            {
                string nome = txNome.Text;
                string preco = txPreco.Text;
                string quantidade = txQuantidade.Text;
                string descricao = txDescricao.Text;

                string mensagem = controller.SalvarProduto(nome, preco, quantidade, descricao);
                MessageBox.Show(mensagem);

                AtualizarLista();
            };
            this.Controls.Add(btCadastrar);

            additionalFieldsRendered = true;

            MessageBox.Show("Campos adicionais renderizados com sucesso");
        }


        private void btCriar_Click_1(object sender, EventArgs e)
        {
            if (additionalFieldsRendered)
            {
                MessageBox.Show("Os campos adicionais já estão renderizados!");
                return;
            }
            else
            {
                renderizar();
            }

        }

        private void lbPreco_Click(object sender, EventArgs e)
        {

        }
    }
}
