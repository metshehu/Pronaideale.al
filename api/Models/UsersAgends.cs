using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("UsersAgends")]
    public class UsersAgends
    {
       public string AppUsersId { get; set; } 
       public int AgendsId{ get; set; }
       public AppUser AppUser{ get; set; }
       public Agends Agends{ get; set; }

    }
}