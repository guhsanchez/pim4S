using ClassesControle.BL;
using ClassesControle.DAO;
using ClassesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesControle.Controller
{
    public class Controller
    {
        private static Controller instancia = null;
        private Controller() { }
        public static Controller getinstancia()
        {
            if (instancia == null)
                instancia = new Controller();
            return instancia;
        }

        public UsuarioDto RealizaLogin(string senha)
        {
            UsuarioDto retorno = UsuarioBL.getinstancia().Login(senha);
            return retorno;
        }
    }
}
