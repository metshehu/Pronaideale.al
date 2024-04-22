using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{

    [Table("Companys")]
    public class Companys
    {
        public int id { get; set; }  
        public string Name {get; set;}=string.Empty;

        public string Adress { get; set; }=string.Empty;

        public string Phone { get; set; }=string.Empty;

        public int Rating { get; set; }
        public List<Agends> Agends {get; set; } = new List<Agends>();
        

    }
}