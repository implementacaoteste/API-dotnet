using DAL;
using Models;

namespace BLL
{
    public class GrupoUsuarioBLL : BLLModelo<GrupoUsuario, GrupoUsuarioDAL>
    {
        public GrupoUsuarioBLL()
        {
            this.DataLayer = new GrupoUsuarioDAL();
        }
    }
}