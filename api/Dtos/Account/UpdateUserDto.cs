using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Account
{
    public class UpdateUserDto
    {
    public string? Email{ get; set; }       
    public string? Password { get; set; }
    }
}