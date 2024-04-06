using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Users
{
    public class CreateUserRequestDto
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Adress{ get; set; }= string.Empty;
        public string Phone { get; set; }=string.Empty;

    }
}