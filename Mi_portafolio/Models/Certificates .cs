using Mi_portafolio.Enums;

namespace Mi_portafolio.Models
{
    public class Certificates
    {
        public int id { get; set; }
        public string nameCertificate { get; set; }
        public string endDate { get; set; }
        public string urlCetificate { get; set; }
        public string urlImage { get; set; }
        public TypeOfCertificate typeOfCertificate {get; set; } 
    }
}
