using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Usuarios
{
    public class Usuarios
    {
        [Required]
        [Column(TypeName = "int")]
        public int Id { get; set; }
    
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Usuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Contraseña { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Estado { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Perfilid { get; set; }
        public Perfil Perfil { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int OrganizacionId {get; set;}
        public Organizacion Organizacion { get; set; }
    }
}
