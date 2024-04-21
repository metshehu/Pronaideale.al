using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Companys
    {
        public int id { get; set; }
        public string Name {get; set;}=string.Empty;
        public List<Agends> Agends {get; set; } = new List<Agends>();


    }
}