namespace Models
{
    public class GrupoUsuario
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public List<Permissao> PermissaoList { get; set; }
        public List<Usuario> UsuarioList { get; set; }
    }
}