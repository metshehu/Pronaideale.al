using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace api.Models
{
    public class AppUser :IdentityUser
    {
        
        public int? IsAgend{ get; set; }
        public List<UsersAgends> Agends{ get; set; }= new List<UsersAgends>();
        public List<Propertys> Propertys { get; set; } = new List<Propertys>();
    }
}