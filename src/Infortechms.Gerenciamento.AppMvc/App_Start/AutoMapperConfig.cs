using AutoMapper;
using Infortechms.Gerenciamento.AppMvc.ViewModels;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using System;
using System.Linq;
using System.Reflection;

namespace Infortechms.Gerenciamento.AppMvc.App_Start
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var profiles = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x));

            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });
        }
    }
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ConsumoCombustivel, ConsumoCombustivelViewModel>().ReverseMap();
        }
    }

}