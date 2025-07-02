using AutoMapper;
using ShippingAPI.DTOS.city_govern;
using ShippingAPI.DTOS.CustomPriceDTOs;
using ShippingAPI.DTOS.OrderDTOs;
using ShippingAPI.DTOS.OrderItemDTOs;
using ShippingAPI.DTOS.ShippingTypeDTOs;
using ShippingAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShippingAPI.MappingConfigs
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            // CustomPrice Mapping
            CreateMap<CustomPrice,addCustomPriceDTO>().ReverseMap();
            CreateMap<CustomPrice, displayCustomPriceDTO>().AfterMap(
                (src, dest) =>
                {
                    dest.UserName = src.TraderProfile?.User.UserName ?? "Unknown User";
                    dest.CityName = src.City?.Name ?? "Unknown City";
                }).ReverseMap();

            // ShippingType Mapping
            CreateMap<ShippingType, addShippingTypeDTO>().ReverseMap();
            CreateMap<ShippingType, displayShippingTypeDTO>().ReverseMap();

            // Order Mapping
            CreateMap<Order, addOrderDTO>().ReverseMap();
            CreateMap<Order , displayOrderDTO>().AfterMap(
                (src, dest) =>
                {
                    dest.BranchName = src.Branch.Name;
                    dest.TraderName = src.TraderProfile.User.FullName;
                    dest.CityName = src.City.Name;
                    dest.RejectionReason = src.RejectionReason.Reason;
                    dest.GovernorateName = src.Governorate.Name;

                }
                ).ReverseMap();
            // OrderItem Mapping
            CreateMap<OrderItem, addOrderItemDTO>().ReverseMap();
            CreateMap<OrderItem, displayOrderItemDTO>().ReverseMap();
            //city mapping
            // cityDTO
            CreateMap<City, cityDTO>()
                .ForMember(dest => dest.GoverrateName, opt => opt.MapFrom(src => src.Governorate.Name))
                .ReverseMap();

            // cityidDTO
            CreateMap<City, cityidDTO>()
                .ForMember(dest => dest.GoverrateName, opt => opt.MapFrom(src => src.Governorate.Name))
                .ReverseMap();

            // من DTO لـ Entity
            CreateMap<cityDTO, City>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.PricePerKg, opt => opt.MapFrom(src => src.PricePerKg))
                .ForMember(dest => dest.PickupCost, opt => opt.MapFrom(src => src.PickupCost))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Governorate, opt => opt.Ignore()); // هتربطي الـ Governorate بإيدك بالـ Id في الكنترولر

            CreateMap<cityidDTO, City>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.PricePerKg, opt => opt.MapFrom(src => src.PricePerKg))
                .ForMember(dest => dest.PickupCost, opt => opt.MapFrom(src => src.PickupCost))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.Governorate, opt => opt.Ignore()); // برضو تربطي الـ GovernorateId بنفسك في الكنترولر

            //governorate mapping

            CreateMap<Governorate, governrateDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))

                .ReverseMap();
            CreateMap<Governorate, governrateidDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))

                .ReverseMap();



        }
    }
}
