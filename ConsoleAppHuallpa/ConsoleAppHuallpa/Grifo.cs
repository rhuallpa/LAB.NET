using ConsoleAppHuallpa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHuallpa
{


    public class Grifo
    {
        private List<Usuario> usuarios = new List<Usuario>();

        // Método para agregar usuario a la lista
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        // Método para mostrar información de usuarios
        public void MostrarUsuarios()
        {
            foreach (var usuario in usuarios)
            {
                usuario.MostrarInformacion();
            }
        }
    }

}



