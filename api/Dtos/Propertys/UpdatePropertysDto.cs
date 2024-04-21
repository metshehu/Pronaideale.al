using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Propertys
{
    public class UpdatePropertysDto
    {
        public string Name { get; set; }=string.Empty;
        public string Street { get; set; }=string.Empty;
        public string City { get; set; }=string.Empty;
        public int UsersId { get; set; }
    }
}