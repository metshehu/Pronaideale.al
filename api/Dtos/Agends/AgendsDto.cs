using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Agends
{
    public class AgendsDto
    {
        public int id { get; set; }
        public string Phone { get; set; }=string.Empty;

        public string Deals { get; set; }=string.Empty;
        public string YoE { get; set; }=string.Empty;
        public int CompanysId { get; set; }
    }
}