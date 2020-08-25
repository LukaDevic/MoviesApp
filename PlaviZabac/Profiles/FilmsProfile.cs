using AutoMapper;
using PlaviZabac.Models;

namespace PlaviZabac.Profiles
{
    public class FilmsProfile : Profile
    {
        public FilmsProfile()
        {
            CreateMap<FilmViewModel, Film>();
        }
    }
}
