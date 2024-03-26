using DAL;
using Models;

namespace BLL
{
    public class CategoriaProdutoBLL
    {
        private void ValidarDados(CategoriaProduto _categoriaProduto, bool _estaInserindo = true)
        {
            if (_categoriaProduto == null)
                throw new Exception("Informe uma categoria de produto válida.");
        }
        public void Inserir(CategoriaProduto _categoriaProduto)
        {
            ValidarDados(_categoriaProduto);
            new CategoriaProdutoDAL().Inserir(_categoriaProduto);
        }
        public List<CategoriaProduto> BuscarTodos()
        {
            return new CategoriaProdutoDAL().BuscarTodos();
        }
        public CategoriaProduto? BuscarPorId(int _id)
        {
            return new CategoriaProdutoDAL().BuscarPorId(_id);
        }
        public void Alterar(CategoriaProduto _categoriaProduto)
        {
            ValidarDados(_categoriaProduto, false);
            new CategoriaProdutoDAL().Alterar(_categoriaProduto);
        }
        public void Excluir(int _id)
        {
            new CategoriaProdutoDAL().Excluir(_id);
        }
    }
}