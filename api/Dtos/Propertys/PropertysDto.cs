using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Propertys
{
    public class PropertysDto
    {

        public int id { get; set; }
        public string Name { get; set; } =string.Empty;
        public string Street { get; set; } =string.Empty;
        public string City { get; set; }  =string.Empty;

        public string? AppUsersId { get; set; }
    }
}