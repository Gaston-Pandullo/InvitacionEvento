using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvitacionWeb.Models
{
    public class Invitado
    {
        public int Id {get; set;}
        
        [Required]
        public string Nombre{get; set;}
        
        [Required]
        public string Apellido{get; set;}
    }
}