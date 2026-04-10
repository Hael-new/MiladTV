using System.ComponentModel.DataAnnotations;

namespace MiladTV.Models
{
    public class Client
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "Vyplňte Website")]
        public string Website { get; set; } = "";

        [Required(ErrorMessage = "Vyplňte titulek")]
        [StringLength(100, ErrorMessage = "Titulek je příliš dlouhý")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Vyplňte obsah")]
        public string Description { get; set; } = "";

    }
}
