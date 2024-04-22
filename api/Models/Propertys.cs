using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Propertys")]
    public class Propertys
    {
        public int id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Street { get; set; }=string.Empty;
        public string City { get; set; }
        [Column(TypeName ="decimal(18,2 )")]        
        public decimal STrange { get; set; }
        [Column(TypeName ="decimal(18,2 )")]        
        public decimal Enrange { get; set; }
        [Column(TypeName ="decimal(18,2 )")]
        public decimal Monthly { get; set; }
        [Column(TypeName ="decimal(30,5 )")]
        public decimal Size { get; set; }
        public string? AppUsersId { get; set; }
        public AppUser? AppUsers { get; set; }

        public List<AgendsPropertys>? Agends{ get; set; }

          }
}