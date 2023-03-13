using Mi_portafolio.Enums;
using Mi_portafolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mi_portafolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        List<Projects> listProjects = new List<Projects>()
        {
            new Projects { 
                Id = 1, 
                Title = "Formato Apa",
                Description = "Una aplicación web de generador de formato apa.",
                Skills = "Html + Css + Javascript + Bootstrap",
                UrlImage = "https://raw.githubusercontent.com/Alane-Tc/mi_portafolio_alane_tc/developer/src/assets/img/proyectos-personales/proyecto_1.png",
                UrlProject = "urlProyecto",
                UrlRepository = "UrlReposory",
                typeProject = TypeProject.Personal_project
            },
            new Projects {
                Id = 2,
                Title = "Formato Apa Desktop",
                Description = "Formato Apa en versión de escritorio desarrollada con electron.",
                Skills = "Html + Css + Javascript + Bootstrap",
                UrlImage = "https://raw.githubusercontent.com/Alane-Tc/mi_portafolio_alane_tc/developer/src/assets/img/proyectos-personales/proyecto_1.png",
                UrlProject = "urlProyecto",
                UrlRepository = "UrlReposory",
                typeProject = TypeProject.Personal_project
            },
            new Projects {
                Id = 3,
                Title = "Cuantos días faltan",
                Description = "Aplicación que calcula fácilmente el tiempo transcurrido entre dos fechas diferentes, y/o te da los días faltantes de las fechas festivas.",
                Skills = "Html + Sass + Javascript + Bootstrap",
                UrlImage = "https://raw.githubusercontent.com/Alane-Tc/mi_portafolio_alane_tc/developer/src/assets/img/proyectos-personales/proyecto_1.png",
                UrlProject = "urlProyecto",
                UrlRepository = "UrlReposory",
                typeProject = TypeProject.Personal_project
            },
             new Projects {
                Id = 4,
                Title = "Lotería Mexicana",
                Description = "Barajeo para el juego de mesa lotería mexicana.",
                Skills = "Html + Sass + Javascript + Bootstrap",
                UrlImage = "https://raw.githubusercontent.com/Alane-Tc/mi_portafolio_alane_tc/developer/src/assets/img/proyectos-personales/proyecto_1.png",
                UrlProject = "urlProyecto",
                UrlRepository = "UrlReposory",
                typeProject = TypeProject.Personal_project
            },
             new Projects {
                Id = 5,
                Title = "PokeDex",
                Description = "Sitio web realizada con la API de pokemon, donde busca información de ataque y defensa de un pokemon.",
                Skills = "Html + Sass + Javascript + Bootstrap",
                UrlImage = "https://raw.githubusercontent.com/Alane-Tc/mi_portafolio_alane_tc/developer/src/assets/img/proyectos-personales/proyecto_1.png",
                UrlProject = "urlProyecto",
                UrlRepository = "UrlReposory",
                typeProject = TypeProject.Personal_project
            },
        };

        [HttpGet]
        [Route("api/GetProjectsPersonalProject")]
        public async Task<ActionResult<IEnumerable<Projects>>> GetProjectsPersonalProject()
        {
            var carta = listProjects
                        .Where(c => c.typeProject == (TypeProject.Personal_project))
                        .ToList();
            return carta;

        }

        [HttpGet]
        [Route("api/Projects/GetProjectsFreelancerProject")]
        public async Task<ActionResult<IEnumerable<Projects>>> GetProjectsFreelancerProject()
        {
            var carta = listProjects
                .Where(c => c.typeProject == (TypeProject.Freelancer_project))
                .ToList();
            return carta;

        }
    }
}
