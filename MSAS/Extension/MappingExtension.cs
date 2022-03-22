using MSAS.Core.UsersMgt;
using MSAS.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MSAS.Core.StatesLGA;
using MSAS.Models.StateLGA;

namespace MSAS.Extension
{
    public static class MappingExtension
    {
        private static MapperConfiguration config;
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            
           //return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
             config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper.Map<TSource, TDestination>(source);
            
        } 

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });

            IMapper mapper = config.CreateMapper();

            return mapper.Map<TSource, TDestination>(source);
            
            //return AutoMapperConfiguration.Mapper.Map(source, destination);
        }

        #region Users

       

        
        public static UsersViewModel ToModel(this Users entity)
        {
            return entity.MapTo<Users, UsersViewModel>();
        }

        public static Users ToEntity(this UsersViewModel model)
        {
            return model.MapTo<UsersViewModel, Users>();
            //var mapper = config.CreateMapper();
           // mapper.Map<Source, Dest>(foo);
        }

       /* public static Users ToEntity(this UsersViewModel model, Users destination)
        {
            return model.MapTo(destination);
        }*/

        #endregion

        #region States

        public static StateViewModel ToModel(this State entity)
        {
            return entity.MapTo<State, StateViewModel>();
        }

        public static State ToEntity(this StateViewModel model)
        {
            return model.MapTo<StateViewModel, State>();
           
        }

       public static State ToEntity(this StateViewModel model, State destination)
        {
            return model.MapTo(destination);
        }

        #endregion

       #region LGA

       public static LGAViewModel ToModel(this LGA entity)
       {
           return entity.MapTo<LGA, LGAViewModel>();
       }

       public static LGA ToEntity(this LGAViewModel model)
       {
           return model.MapTo<LGAViewModel, LGA>();

       }

       public static LGA ToEntity(this LGAViewModel model, LGA destination)
       {
           return model.MapTo(destination);
       }

       #endregion

    }
}