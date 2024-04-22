using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{

    [Table("Agends")]
    public class Agends
    {
        public int id { get; set; }
        public string? AppUserid{ get; set; }
        public AppUser? AppUser{ get; set; }


        public string Phone { get; set; }=string.Empty;
        public int Deals { get; set; } 
        public int YoE {get; set;}
        public string Description { get; set; }=string.Empty;
        public int? CompanysId {get; set;}
        public Companys? Companys {get; set;}
        public List<UsersAgends> AppUsers{ get; set; }= new List<UsersAgends>();

        public List<AgendsPropertys> Propertys{ get; set; }= new List<AgendsPropertys>();
    }
}