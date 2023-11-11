using Proyecto_grafica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grafica
{
    static class CargarGuion
    {
        public static void Cargar(Escenario scenario, Guion G1)
        {
            Accion A1 = new Accion();

            Action accion = () => scenario.GetObjeto("auto").Trasladar(0.1f, 0, 0);
            Action accion10 = () => scenario.GetObjeto("auto").GetParte("llanta1").Rotar(-4, 0, 0, 1);
            Action accion20 = () => scenario.GetObjeto("auto").GetParte("llanta2").Rotar(-4, 0, 0, 1);
            Action accion30 = () => scenario.GetObjeto("auto").GetParte("llanta3").Rotar(-4, 0, 0, 1);
            Action accion40 = () => scenario.GetObjeto("auto").GetParte("llanta4").Rotar(-4, 0, 0, 1);
            A1.objeto.Add(accion);
            A1.objeto.Add(accion10);
            A1.objeto.Add(accion20);
            A1.objeto.Add(accion30);
            A1.objeto.Add(accion40);

            G1.AgregarAccion(A1.objeto, 50);

            Action accion5 = () => scenario.GetObjeto("auto").Trasladar(0.1f, -0.1f, 0);
            Action accion6 = () => scenario.GetObjeto("auto").Rotar(-1.75f, 0, 0, 1);
            Action accion11 = () => scenario.GetObjeto("auto").GetParte("llanta1").Rotar(-4, 0, 0, 1);
            Action accion12 = () => scenario.GetObjeto("auto").GetParte("llanta2").Rotar(-4, 0, 0, 1);
            Action accion13 = () => scenario.GetObjeto("auto").GetParte("llanta3").Rotar(-4, 0, 0, 1);
            Action accion14 = () => scenario.GetObjeto("auto").GetParte("llanta4").Rotar(-4, 0, 0, 1);
            Accion A2 = new Accion();
            A2.objeto.Add(accion5);
            A2.objeto.Add(accion6);
            A2.objeto.Add(accion11);
            A2.objeto.Add(accion12);
            A2.objeto.Add(accion13);
            A2.objeto.Add(accion14);

            G1.AgregarAccion(A2.objeto, 105);

            Accion A3 = new Accion();
            Action accion1 = () => scenario.GetObjeto("auto").GetParte("llanta1").Rotar(-4, 0, 0, 1);
            Action accion2 = () => scenario.GetObjeto("auto").GetParte("llanta2").Rotar(-4, 0, 0, 1);
            Action accion3 = () => scenario.GetObjeto("auto").GetParte("llanta3").Rotar(-4, 0, 0, 1);
            Action accion4 = () => scenario.GetObjeto("auto").GetParte("llanta4").Rotar(-4, 0, 0, 1);
            A3.objeto.Add(accion1);
            A3.objeto.Add(accion2);
            A3.objeto.Add(accion3);
            A3.objeto.Add(accion4);

            G1.AgregarAccion(A3.objeto, 50);
        }
    }
}
