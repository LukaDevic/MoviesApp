using System;
using System.ComponentModel.DataAnnotations;

namespace PlaviZabac.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ime je obavezano")]
        [StringLength(255)]
        public string Ime { get; set; }

        public Zanr Zanr { get; set; }

        [Display(Name = "Zanr")]
        [Required(ErrorMessage = "Zanr je obavezan")]
        public byte ZanrId { get; set; }

        [Display(Name = "Datum objave")]
        [Required(ErrorMessage = "Datum Objave je obavezano")]
        public DateTime DatumObjave { get; set; }

        [Display(Name = "Broj na stanju")]
        [Required(ErrorMessage = "BrojNaStanju je obavezano")]
        [Range(1, 20)]
        public byte BrojNaStanju { get; set; }

        public Prodavnica Prodavnica { get; set; }

        [Display(Name = "Nalazi se u prodavnici")]
        [Required(ErrorMessage = "ProdavnicaId je obavezano")]
        [Range(1, 20)]
        public byte ProdavnicaId { get; set; }
    }
}
