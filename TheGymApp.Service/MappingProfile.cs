using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TheGymApp.Data;
using TheGymApp.Service.Models;

namespace TheGymApp.Service
{
   public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ZSysUserDTO, ZSysUser>();
        }
    }
}
