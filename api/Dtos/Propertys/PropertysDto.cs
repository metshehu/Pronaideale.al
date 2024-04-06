using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Propertys
{
    public class PropertysDto
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }   
    }
}