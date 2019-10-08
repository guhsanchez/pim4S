using ClassesControle.DAO;
using ClassesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesControle.BL
{
    public class UsuarioBL
    {
        private static UsuarioBL instancia = null;
        private UsuarioBL() { }
        public static UsuarioBL getinstancia()
        {
            if (instancia == null)
                instancia = new UsuarioBL();
            return instancia;
        }

        public UsuarioDto Login(string senha)
        {
            if (string.IsNullOrEmpty(senha))
            {
                throw new Exception("Nome do usuário ou senha inválida");
            }

            UsuarioDto retorno = UsuarioDao.getinstancia().Login(senha);
            return retorno;
        }
    }
}
