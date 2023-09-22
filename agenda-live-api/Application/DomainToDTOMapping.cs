using agenda_live_api.Domain.DTOs;
using agenda_live_api.Domain.Models;
using AutoMapper;

namespace agenda_live_api.Application
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Live, LiveDTO>();
        }
    }
}
