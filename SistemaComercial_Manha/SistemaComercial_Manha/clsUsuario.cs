using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercial_Manha
{
    class clsUsuario
    {
        static private String usuario;
        
        static public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
