using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Productos
{
    public class Productos
    {
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int tipoId { get; set; }
        public Tipo Tipo { get; set; }
    }
}
