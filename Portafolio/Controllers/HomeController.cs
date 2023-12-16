using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectRepository projectRepository;
		private readonly IServiceEmail serviceEmail;

		public HomeController(ILogger<HomeController> logger, IProjectRepository projectRepository, IServiceEmail serviceEmail)
        {
            _logger = logger;
            this.projectRepository = projectRepository;
			this.serviceEmail = serviceEmail;
		}

        public IActionResult Index()
        {
            List<ProjectsViewModel> projects = projectRepository.GetProjects().Take(3).ToList();

            HomeIndexViewModel modelo = new HomeIndexViewModel();
            modelo.Projects = projects;

            return View(modelo);
        }

        public IActionResult Projects()
        {
            var projects = projectRepository.GetProjects();

            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contactViewModel)
        {
            await serviceEmail.Send(contactViewModel);
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}