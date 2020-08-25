using System.ComponentModel.DataAnnotations;

namespace PlaviZabac.Models
{
    public class Prodavnica
    {
        public byte Id { get; set; }

        [Required(ErrorMessage = "Ime je obavezano")]
        [StringLength(255)]
        public string Ime { get; set; }
    }
}
