using AutoMapper;
using Model = Skynet.WebAPI.Viewmodels.Model.Model;

namespace Skynet.WebAPI.Extensions.Automapper.Profiles
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Domain.CrossModels.Enums.Model, Model>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x));
        }
    }
}
