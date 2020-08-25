using System.ComponentModel.DataAnnotations;

namespace PlaviZabac.Models
{
    public class Kontakt
    {
        [Required(ErrorMessage = "Polje email je obavezano")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Polje komentar je obavezano")]
        public string Komentar { get; set; }
    }
}
