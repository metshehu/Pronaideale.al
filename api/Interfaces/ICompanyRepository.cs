using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Companys;
using api.Models;

namespace api.Interfaces
{
    public interface ICompanyRepository
    {
        Task<List<Companys>> GetAllAsync();
       Task<Companys?> GetByIdAsync(int id );
       Task<Companys> CreateAsync(Companys compnaymodel);
       Task<Companys?> UpdateAsync(int id,UpdateCompanyDto compnayDtop);

       Task<Companys?> DeletAsync(int id );

    }
}