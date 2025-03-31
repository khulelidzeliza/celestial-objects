using AutoMapper;
using WebApplication5.DTO;
using WebApplication5.Model;
using WebApplication5.Request;

namespace WebApplication5.Mapping
{
    public class mapper : Profile
    {
        public mapper()
        {
            CreateMap<AddCelestilObject, CelestialObject>();

            CreateMap<CelestialObject, DisplayInfoDTO>();
            CreateMap<CelestialObject, DetInfoDTO>();
            CreateMap<CelestialObject, ScientificDTO>();
            CreateMap<CelestialObject, LocationDTO>();
            CreateMap<CelestialObject, HistoryDTO>();
            CreateMap<CelestialObject, CompositionDTO>();
            CreateMap<CelestialObject, ClassificationDTO>();
            CreateMap<CelestialObject, OrbitDTO>();
            CreateMap<CelestialObject, CelestialObjectsDTO>();
            CreateMap<CelestialObject, ConstellationDTO>();
            CreateMap<CelestialObject, InterestingDTO>();
            CreateMap<CelestialObject, SearchDTO>();
        }
    }
}
