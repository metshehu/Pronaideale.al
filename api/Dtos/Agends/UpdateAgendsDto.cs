using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Agends
{
    public class UpdateAgendsDto
    {
        public string Phone { get; set; }=string.Empty;
        public int Deals { get; set; }
        public int YoE { get; set;} 
        public int CompanysId { get; set; }
    }
}