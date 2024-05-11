using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfertApp.Models;

namespace OfertApp.Controllers
{
    public class MainController
    {
        private static List<UsuarioModel> usuarios = new List<UsuarioModel>();
        private static List<PublicacionModel> publicaciones = new List<PublicacionModel>();
        private static List<FeedModel> contenedorPublicaciones = new List<FeedModel>();

        public static void crearPublicacion(string usuario, string descripcion, DateTime inicioPromo, DateTime finPromo)
        {
            /*
             publicaciones.Add(new PublicacionModel(usuario, descripcion, inicioPromo, finPromo);     
             mostrarFeed();
            */
        }

        public static void modificarPublicacion()
        {
            /*
            paso el id de la publicacion seleccionada
            modifico los datos de la publicacion con ese ID selecionado
            */
        }

        public static void eliminarPublicacion()
        {
            /*
            paso el id de la publicacion seleccionada
            modifico los datos de la publicacion con ese ID selecionado
            */
        }

        public static void votarPublicacion()
        {
            /*
            si el usuario selecciona uno de los dos votos, quita la posibilidad de seleccionar 
            el boton nuevamente para votar a favor o en contra. Habilita otro voton para quitar
            el voto seleccionado previamente
            */           
        }

        public static void actualizarFeed()
        {
            /*
            foreach(PublicacionModel publicacion in publicaciones)
                mostrarPublicacion(publicacion);
            */
        }

        public static void mostrarPublicaciones()
        {
            /*
             
            */
        }
    }
}
