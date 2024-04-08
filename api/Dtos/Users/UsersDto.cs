using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Propertys;

namespace api.Dtos.Users
{
    public class UsersDto
    {
        
        public int id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Lastname { get; set; }=string.Empty;
        public string Adress{ get; set; }= string.Empty;
        public string Phone { get; set; }=string.Empty;
        public List<PropertysDto> Propertys { get; set; }
    }
}