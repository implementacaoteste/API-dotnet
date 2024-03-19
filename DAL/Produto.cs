using Models;

namespace DAL
{
    public class ProdutoDAL
    {
        List<Produto> produtoList;
        public ProdutoDAL()
        {
            produtoList = new List<Produto>{
                new Produto(){Id = 1, Nome = "Arroz", Preco = 54.35, Estoque = 152},
                new Produto(){Id = 2, Nome = "Feijão", Preco = 22.52, Estoque = 54},
                new Produto(){Id = 3, Nome = "Farinha", Preco = 15.42, Estoque = 38},
            };
        }
        public void Inserir(Produto _produto)
        {
            produtoList.Add(_produto);
        }
        public List<Produto> BuscarTodos()
        {
            return produtoList;
        }
        public Produto BuscarPorId(int _id)
        {
            var produto = produtoList.FirstOrDefault(u => u.Id == _id);

            if(produto == null)
                throw new Exception("Produto naõ encontrado");
            
            return produto;
        }
        public void Alterar(Produto _produto)
        {
            var produto = produtoList.FirstOrDefault(u => u.Id == _produto.Id);

            if(produto != null)
            {
                produto.Nome = _produto.Nome;
                produto.Preco = _produto.Preco;
                produto.Estoque = _produto.Estoque;
            }
        }
        public void Excluir(int _id)
        {
            var produto = produtoList.FirstOrDefault(u => u.Id == _id);

            if(produto != null)
                produtoList.Remove(produto);
        }
    }
}