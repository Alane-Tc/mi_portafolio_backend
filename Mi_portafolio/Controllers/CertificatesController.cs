using Mi_portafolio.Enums;
using Mi_portafolio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mi_portafolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        List<Certificates> listCertificates = new List<Certificates>()
        {
            new Certificates
            {
                id = 1,
                nameCertificate = "Lógica Programación: Aprende Programar en Cualquier Lenguaje",
                endDate = "Enero 2019",
                urlCetificate = "https://www.udemy.com/certificate/UC-N6TILR97/",
                urlImage = "https://s.udemycdn.com/meta/default-meta-image-v2.png",
                typeOfCertificate = TypeOfCertificate.Udemy
            },
            new Certificates
            {
                id = 2,
                nameCertificate = "Aprende HTML5 y CSS3 desde cero",
                endDate = "Febrero 2019",
                urlCetificate = "https://www.udemy.com/certificate/UC-7deb4580-acbf-4d0a-beee-0e0d8a969a67/",
                urlImage = "https://s.udemycdn.com/meta/default-meta-image-v2.png",
                typeOfCertificate = TypeOfCertificate.Udemy
            },
            new Certificates
            {
                id = 3,
                nameCertificate = "Master en CSS: Responsive, SASS, Flexbox, Grid y Bootstrap",
                endDate = "Septiembre 2021",
                urlCetificate = "https://www.udemy.com/certificate/UC-218ad944-c10d-4b9b-ab43-d8283689134b/",
                urlImage = "https://s.udemycdn.com/meta/default-meta-image-v2.png",
                typeOfCertificate = TypeOfCertificate.Udemy
            },
             new Certificates
            {
                id = 4,
                nameCertificate = "JavaScript Moderno: Guía para dominar el lenguaje",
                endDate = "Enero 2022",
                urlCetificate = "https://www.udemy.com/certificate/UC-d28ac077-ab7b-4adb-a1a6-54a4ff4f2dda/",
                urlImage = "https://s.udemycdn.com/meta/default-meta-image-v2.png",
                typeOfCertificate = TypeOfCertificate.Udemy
            },
                  new Certificates
            {
                id = 5,
                nameCertificate = "Programación desde cero",
                endDate = "Noviembre 2020",
                urlCetificate = "ed.team/premium?cupon=",
                urlImage = "https://edteam-media.s3.amazonaws.com/blogs/original/75323425-9ed9-4484-b072-18005273c806.jpg",
                typeOfCertificate = TypeOfCertificate.Edteam
            },
               new Certificates
            {
                id = 6,
                nameCertificate = "C# desde Cero",
                endDate = "Enero 2023",
                urlCetificate = "https://ed.team/premium?cupon=REF-184946",
                urlImage = "https://edteam-media.s3.amazonaws.com/blogs/original/75323425-9ed9-4484-b072-18005273c806.jpg",
                typeOfCertificate = TypeOfCertificate.Edteam
            },
        };


        [HttpGet]
        [Route("api/GetCertificateUdemy")]
        public async Task<ActionResult<IEnumerable<Certificates>>> GetCertificateUdemy()
        {
            var certifiate = listCertificates
                        .Where(c => c.typeOfCertificate == (TypeOfCertificate.Udemy))
                        .ToList();
            return certifiate;

        }

        [HttpGet]
        [Route("api/GetCertificateEdteam")]
        public async Task<ActionResult<IEnumerable<Certificates>>> GetCertificateEdteam()
        {
            var certifiate = listCertificates
                        .Where(c => c.typeOfCertificate == (TypeOfCertificate.Edteam))
                        .ToList();
            return certifiate;

        }
    }
}
