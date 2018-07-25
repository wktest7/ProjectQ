using AutoMapper;
using ProjectQ.Core.Domain;
using ProjectQ.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQ.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<Driver, DriverDTO>();
                //cfg.CreateMap<Driver, DriverDTO>()
                //.ForMember(x => x.MyVehicle, m => m.MapFrom(p => p.Vehicle));
                //inna nazwa w dto, przyklad zmiany
            }).CreateMapper();
        }
    }
}
