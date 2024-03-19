namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario(int _id, string _nome, string _senha)
        {
            Id = _id;
            Nome = _nome;
            Senha = _senha;
        }
    }
}