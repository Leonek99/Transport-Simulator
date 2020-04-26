using AutoMapper;
using Pierwszy_projekt_na_serio.Models.Entity;
using Pierwszy_projekt_na_serio.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pierwszy_projekt_na_serio.Helpper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Client, ClientInformation>().ReverseMap();
            CreateMap<Order, OrderInformation>().ReverseMap();
            CreateMap<OrderHistory, OrderHistoryInformation>().ReverseMap();
            CreateMap<Worker, WorkerInformation>().ReverseMap();
        }
    }
}
