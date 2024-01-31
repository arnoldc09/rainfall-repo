using AutoMapper;
using RainfallApi.Model.Common;
using RainfallApi.Model.Contract;

namespace RainfallApi.Mappings
{
    public class RainfallProfile : Profile
    {
        public RainfallProfile()
        {
            CreateMap<RainfallApiResponse, RainfallContract>();
        }
    }
}
