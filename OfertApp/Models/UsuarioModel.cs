using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertApp.Models
{
    public class UsuarioModel
    {
        private string nombreUsuario { get; set; }
        private string email {  get; set; }

        public UsuarioModel(string nombreUsuario, string email)
        {
            this.nombreUsuario = nombreUsuario;
            this.email = email;
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value;}
        }

        public string Email
        { 
            get { return email; } 
            set {  email = value; } 
        }
    }
}
