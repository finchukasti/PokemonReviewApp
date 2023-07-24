using AutoMapper;
using PokemoReviewApp.Dto;
using PokemoReviewApp.Models;

namespace PokemoReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {       
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Country, CountryDto>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<ReviewDto, Review>();
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewerDto, Reviewer>();
            CreateMap<Reviewer, ReviewerDto>();
            
            
        }
    }
}
