using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDTO>();
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestForCreationDTO>();
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpdateDTO>();
            CreateMap<Models.PointOfInterestForCreationDTO, Entities.PointOfInterest>();
            CreateMap<Models.PointOfInterestForUpdateDTO, Entities.PointOfInterest>();
        }
    }
}
