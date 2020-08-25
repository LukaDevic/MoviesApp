using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlaviZabac.Data;
using PlaviZabac.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace PlaviZabac.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MoviesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index(DateTime? maxReleaseDate, string searchString)
        {
            var movies = _context.Filmovi
                .Include(x => x.Zanr)
                .Include(x => x.Prodavnica)
                .Where(x => x.BrojNaStanju > 0)
                .ToList();

            if (!User.IsInRole(RoleName.Admin))
            {
                return View("ReadOnlyList", movies);
            }

            if (maxReleaseDate != null)
            {
                movies = movies.Where(x => x.DatumObjave <= maxReleaseDate).ToList();
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(x => x.Ime.Contains(searchString)).ToList();
            }

            return View(movies);
        }

        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Create()
        {
            var viewModel = new FilmViewModel
            {
                Zanrovi = _context.Zanrovi.ToList(),
                Prodavnice = _context.Prodavnice.ToList()
            };
            return View("MoviesForm", viewModel);
        }

        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Edit(int id)
        {
            var film = _context.Filmovi.SingleOrDefault(x => x.Id == id);

            if (film == null)
                return NotFound();

            var viewModel = new FilmViewModel(film)
            {
                Zanrovi = _context.Zanrovi.ToList(),
                Prodavnice = _context.Prodavnice.ToList()
            };

            return View("MoviesForm",viewModel);
        }

        [Authorize(Roles = RoleName.Admin)]
        [HttpPost]
        public IActionResult Save(Film film)
        {
            if (!ModelState.IsValid) return View("MoviesForm", film);

            if (film.Id == 0)
            {
                _context.Filmovi.Add(film);
            }
            else
            {
                var movieFromDb = _context.Filmovi.Single(x => x.Id == film.Id);
                movieFromDb.Ime = film.Ime;
                movieFromDb.ZanrId = film.ZanrId;
                movieFromDb.DatumObjave = film.DatumObjave;
                movieFromDb.ProdavnicaId = film.ProdavnicaId;
                movieFromDb.BrojNaStanju = film.BrojNaStanju;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = RoleName.Admin)]
        public IActionResult Delete(int id)
        {
            var movieFromDb = _context.Filmovi.Single(x => x.Id == id);
            _context.Filmovi.Remove(movieFromDb);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}