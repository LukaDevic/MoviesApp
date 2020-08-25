using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlaviZabac.Models
{
    public class FilmViewModel
    {
        public FilmViewModel()
        {
            Id = 0;
        }

        public FilmViewModel(Film film)
        {
            Id = film.Id;
            Ime = film.Ime;
            DatumObjave = film.DatumObjave;
            BrojNaStanju = film.BrojNaStanju;
            ZanrId = film.ZanrId;
            ProdavnicaId = film.ProdavnicaId;
        }

        public IEnumerable<Zanr> Zanrovi { get; set; }

        public IEnumerable<Prodavnica> Prodavnice { get; set; }

        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Polje ime je obavezano")]
        public string Ime { get; set; }

        [Display(Name = "Zanr")]
        [Required(ErrorMessage = "Polje zanr je obavezano")]
        public byte ZanrId { get; set; }

        [Display(Name = "Prodavnica")]
        [Required(ErrorMessage = "Polje prodavnica je obavezano")]
        public byte ProdavnicaId { get; set; }

        [Display(Name = "Datum objave")]
        [Required(ErrorMessage = "Polje datum objave je obavezano")]
        public DateTime DatumObjave { get; set; }

        [Display(Name = "Broj na stanju")]
        [Required(ErrorMessage = "Polje broj na stanju je obavezano")]
        [Range(1, 20)]
        public byte BrojNaStanju { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Uredi Film" : "Novi Film";
            }
        }
    }
}
