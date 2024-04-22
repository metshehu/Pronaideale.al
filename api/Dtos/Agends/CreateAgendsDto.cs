using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Agends
{
    public class CreateAgendsDto
    {
        public string? AppUserid{ get; set; }
        public string Phone { get; set; }
        public int Deals { get; set;} 
        public int YoE { get; set; }
        public int CompanysId { get; set; }

    }
}