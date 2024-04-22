using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Companys;
using api.Models;
namespace api.Mappers
{
    public static class CompnayMapper
    
    {
        
            public static CompanyDto ToCompanyDto(this Companys companysmodel){
            return new CompanyDto{
                id=companysmodel.id,
                Phone=companysmodel.Phone,
                Name=companysmodel.Name,
                Agends=companysmodel.Agends.Select(c => c.ToAgendsDto()).ToList()
            };
            
        }
        public static Companys ToCompanyDtoCreate(this CreateCompanydto CompanyModel){
       return new Companys{
          Name=CompanyModel.Name,
          Adress=CompanyModel.Adress,
          Phone=CompanyModel.Phone,
          Rating=CompanyModel.Rating

          };
      }


    }
}