using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Companys
{
    public class UpdateCompanyDto
    {
        public string Name {get; set;}=string.Empty;

        public string Adress { get; set; }=string.Empty;

        public string Phone { get; set; }=string.Empty;

        public int Rating { get; set; }
 
    }
}