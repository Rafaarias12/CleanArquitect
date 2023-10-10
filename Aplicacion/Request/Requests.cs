using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Request
{
    public class Requests
    {
        public int exito { get; set; }
        public string mensaje { get; set; }
        public object data { get; set; }

        public Requests()
        {
            this.exito = 0;
        }
    }
}
