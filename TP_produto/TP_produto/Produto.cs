using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP_produto
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
    }
    public class ProdutoModel
    {
        private static List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto p)
        {
            produtos.Add(p);
        }
        public List<Produto> ListarProdutos()
        {
            return produtos;
        }
    }

    public class ProdutoController
    {
        private ProdutoModel model = new ProdutoModel();

        public string SalvarProduto(string nome, string precoString, string quantidadeString, string descricao)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(precoString) || string.IsNullOrEmpty(quantidadeString) || string.IsNullOrEmpty(descricao)) 
            {
                return "Nome e preço são obrigatórios!";
            }
            if (!decimal.TryParse(precoString, out decimal preco))
            {
                return "Preço inválido!";

            }
            if (!int.TryParse(quantidadeString, out int quantidade))
            {
                return "Quantidade inválida!";

            }
            Produto p = new Produto 
            { 
            
               Nome = nome,
               Preco = preco,
               Quantidade = quantidade,
               Descricao = descricao
            };

            model.AdicionarProduto(p);
            return "Produto cadastrado com sucesso!";
        }
        public List<Produto> ObterProdutos()
        {
            return model.ListarProdutos();
        }
    }


}
