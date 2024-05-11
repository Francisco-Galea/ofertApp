using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertApp.Models
{
    public class PublicacionModel
    {
        private UsuarioModel publicacionUsuario { get; set; }  
        private string descripcion { set; get; }
        private DateTime inicioPromo { set; get; }
        private DateTime finPromo { set; get; }
        private int votosPositivos {  set; get; }
        private int votosNegativos {  set; get; }

        public PublicacionModel(UsuarioModel publicacionUsuario, string descripcion, DateTime inicioPromo, DateTime finPromo, int votosPositivos, int votosNegativos)
        {
            this.publicacionUsuario = publicacionUsuario;
            this.descripcion = descripcion;
            this.inicioPromo = inicioPromo;
            this.finPromo = finPromo;
            this.votosPositivos = votosPositivos;
            this.votosNegativos = votosNegativos;
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }       
        public DateTime InicioPromo
        {
            get { return inicioPromo; }
            set { inicioPromo = value; }
        }
        public DateTime FinPromo
        {
            get { return finPromo; }
            set { finPromo = value; }
        }
        public int VotosPositivos
        {
            get { return votosPositivos; }
            set { votosPositivos = value;}
        }
        public int VotosNegativos
        {
            get { return votosNegativos; }
            set { votosNegativos = value;}
        }
    }
}
