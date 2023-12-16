using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IProjectRepository
    {
        List<ProjectsViewModel> GetProjects();
    }
}
