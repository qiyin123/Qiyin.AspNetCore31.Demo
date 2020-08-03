using AutoMapper;
using AutoMapper.Configuration.Conventions;
using Qiyin.AspNetCore31.Demo.Dto;
using Qiyin.AspNetCore31.Demo.Models;
using Qiyin.AspNetCore31.Demo.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.Utility
{
    public  class MapperProvider
    {
        private static readonly MapperProvider _instance = new MapperProvider();
        public static MapperProvider Instance
        {
            get { return _instance; }
        }
        private IMapper mapper;
        private MapperProvider()
        {
            var config = new MapperConfiguration(cfg=>
            {
                //类的映射
                cfg.CreateMap<UserLoginArgs, UserDto>()
                .ForMember(d=>d.Id,m=>m.Ignore())
                .ForMember(d=>d.Age,m=>m.Ignore());
                cfg.CreateMap<UserInfoArgs, UserDto>()
                .ForMember(d=>d.Id,m=>m.Ignore());
                cfg.CreateMap<UserDto, UserResult>();

            });
            mapper = config.CreateMapper();
        }
        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}
