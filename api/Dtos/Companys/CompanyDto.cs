using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Agends;

namespace api.Dtos.Companys
{
    public class CompanyDto
    {
        public int id{ get; set; }
        public string Name {get; set;}=string.Empty;

        public string Adress { get; set; }=string.Empty;

        public string Phone { get; set; }=string.Empty;

        public int Rating { get; set; }
        public required List<AgendsDto> Agends {get; set; }
        }
}