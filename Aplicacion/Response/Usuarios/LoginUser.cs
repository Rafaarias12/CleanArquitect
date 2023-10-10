using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Response.Usuarios
{
    public class LoginUser
    {
        [Required]
        public string usuario { get; set; }
        [Required]
        public string password { get; set; }
    }
}
