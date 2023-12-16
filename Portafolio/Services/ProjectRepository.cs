using Portafolio.Models;

namespace Portafolio.Services
{
    /*
     * Esta clase se encarga de servir los datos.
     * 
     * Se conecta con una base de datos para conseguir los datos o realizar cualquier
     * operación en la base de datos.
     */
    public class ProjectRepository : IProjectRepository
    {
        public List<ProjectsViewModel> GetProjects()
        {
            return new List<ProjectsViewModel>()
            {
                new ProjectsViewModel
                {
                    Title = "App Abarrotes Villa",
                    Description = "Control de almacen de las entradas y salidas del negocio y establecimiento de los precios de los productos",
                    Link = "https://github.com/OrlandoHernandezGzz/App-Movil-Abarrotes-Villa",
                    ImageURL = "https://th.bing.com/th/id/OIP.5oxMycCej-zSQJuqXos5nAHaEK?pid=ImgDet&rs=1"
                },

                new ProjectsViewModel
                {
                    Title = "Plataforma Web Abarrotes Villa",
                    Description = "Plataforma para visualizar las entradas y salidas de los productos, adjuntar anuncios publicitarios, venta en línea, etc ",
                    Link = "https://github.com/OrlandoHernandezGzz/plataformaWeb_abarrotesVilla",
                    ImageURL = "https://th.bing.com/th/id/OIP.5oxMycCej-zSQJuqXos5nAHaEK?pid=ImgDet&rs=1"
                },

                new ProjectsViewModel
                {
                    Title = "Encriptador de Texto",
                    Description = "Proyecto para poner a prueba mis conocimientos en JS",
                    Link = "https://github.com/OrlandoHernandezGzz/Encriptador-texto",
                    ImageURL = "https://th.bing.com/th/id/OIP.5oxMycCej-zSQJuqXos5nAHaEK?pid=ImgDet&rs=1"
                }
            };
        }
    }
}
