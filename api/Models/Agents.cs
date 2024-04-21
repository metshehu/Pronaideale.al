using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Agends
    {
        public int id { get; set; }

        public string Name { get; set; }=string.Empty;
        public string Lastname { get; set; }=string.Empty;
        public string Adress{ get; set; }= string.Empty;

        public string Phone { get; set; }=string.Empty;
        public int Deals { get; set; } 
        public int YoE {get; set;}
        public string Description { get; set; }=string.Empty;
        public int? CompanysId {get; set;}
        public Companys? Companys {get; set;}
        public List<Users> Users { get; set; }= new List<Users>();
        public List<Propertys> Propertys {get; set; }= new List<Propertys>();
    }
}