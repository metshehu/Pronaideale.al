using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace api.Models
{
    public class Users
    {
        public int id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Lastname { get; set; }=string.Empty;
        public string Adress{ get; set; }= string.Empty;
        public string Phone { get; set; }=string.Empty;

        public List<Propertys> Propertys { get; set; } = new List<Propertys>();
    }
}