using Mi_portafolio.Enums;

namespace Mi_portafolio.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string UrlImage { get; set; }
        public string UrlProject { get; set; }
        public string UrlRepository { get; set; }
        public TypeProject typeProject { get; set; }
    }
}
