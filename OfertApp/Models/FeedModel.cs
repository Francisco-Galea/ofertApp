using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertApp.Models
{
    public class FeedModel
    {
        private List<PublicacionModel> publicaciones {  get; set; }

        public FeedModel(List<PublicacionModel> publicaciones)
        {
            this.publicaciones = publicaciones;
        }

        public List<PublicacionModel> Publicaciones
        {
            get {  return publicaciones; }
            set {  publicaciones = value; }
        }
    }
}
