using AutoMapper;
using RWA_FinalProject.Models;
using RWA_FinalProject.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.App_Start
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; set; }

        public static void Init()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Kupac, KupacDto>());

            Mapper = config.CreateMapper();
        }

        
    }
}