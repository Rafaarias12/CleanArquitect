using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Usuarios
{
    public class Perfil
    {
        [Required]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Descripcion { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int estado { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
