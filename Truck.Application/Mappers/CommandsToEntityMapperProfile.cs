using AutoMapper;
using Truck.Application.Commands;
using Truck.Domain.Entities;

namespace Truck.Application.Mappers
{
    public class CommandsToEntityMapperProfile : Profile
    {
        public CommandsToEntityMapperProfile()
        {
            AllowNullCollections = true;

            CreateMap<TruckCreateCommand, TruckEntity>()
                .ForMember(dest => dest.Chassis, cfg => cfg.MapFrom(source => source.Chassis))
                .ForMember(dest => dest.Color, cfg => cfg.MapFrom(source => source.Color))
                .ForMember(dest => dest.DateFabric, cfg => cfg.MapFrom(source => source.DateFabric))
                .ForMember(dest => dest.DateModel, cfg => cfg.MapFrom(source => source.DateModel))
                .ForMember(dest => dest.EModelTruck, cfg => cfg.MapFrom(source => source.EModelTruck))
                .ForMember(dest => dest.DateCreation, cfg => cfg.MapFrom(source => source.DateCreation));

            CreateMap<TruckUpdateCommand, TruckEntity>()
               .ForMember(dest => dest.Id, cfg => cfg.MapFrom(source => source.Id))
               .ForMember(dest => dest.Chassis, cfg => cfg.MapFrom(source => source.Chassis))
               .ForMember(dest => dest.Color, cfg => cfg.MapFrom(source => source.Color))
               .ForMember(dest => dest.DateFabric, cfg => cfg.MapFrom(source => source.DateFabric))
               .ForMember(dest => dest.DateModel, cfg => cfg.MapFrom(source => source.DateModel))
               .ForMember(dest => dest.EModelTruck, cfg => cfg.MapFrom(source => source.EModelTruck))
               .ForMember(dest => dest.DateUpdated, cfg => cfg.MapFrom(source => source.DateUpdated));

            CreateMap<TruckDeleteCommand, TruckEntity>()
              .ForMember(dest => dest.Id, cfg => cfg.MapFrom(source => source.Id));
        }
    }
}