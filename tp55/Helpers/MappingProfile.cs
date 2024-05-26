using AutoMapper;
using tp55.Dtos;
using tp55.Models;

namespace tp55.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDto, Movie>().ForMember(src => src.Poster, opt => opt.Ignore());
        
        }
    }
}
