using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grafica
{
    public class Accion
    {
        public List<object> objeto { get; set; }
        public int tiempo { get; set; }

        public Accion(List<object> accion, int tiempoSeg)
        {
            objeto = accion;
            tiempo = tiempoSeg;
        }
        public Accion()
        {
            this.objeto = new List<object>();
            this.tiempo = 0;
        }
    }
}
