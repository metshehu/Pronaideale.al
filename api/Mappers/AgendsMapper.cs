using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using api.Dtos.Agends;
using api.Models;

namespace api.Mappers
{
    public static class AgendsMapper
    {

        public static AgendsDto ToAgendsDto(this Agends agendsmodel){
            return new AgendsDto{
                id=agendsmodel.id,
                Phone=agendsmodel.Phone,
            };
        }
      public static Agends ToAgendsFromCreate(this CreateAgendsDto agendsDtomodel){
       return new Agends{
        AppUserid=agendsDtomodel.AppUserid,
        Phone =agendsDtomodel.Phone,
        Deals =agendsDtomodel.Deals,
        YoE =agendsDtomodel.YoE,
        CompanysId =agendsDtomodel.CompanysId
          };
      }
    }
}