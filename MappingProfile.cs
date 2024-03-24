using AutoMapper;
using DoIT.Data.Model;
using DoIT.Data.Model.DTO;

namespace DoIT
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lector, LectorCreateDTO>().ReverseMap();
        }
    }
}
