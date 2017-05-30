using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.BLAplicacionWeb.Dominio.Acciones
{
    public class ObtenerFechaActual
    {
        public string ObtengaLaFecha() {

            var laEspecificacion = new Especificaciones.ObtengaFecha();
            var laFecha = laEspecificacion.FormatearUnaFecha(DateTime.Now, "dd/mm/yyyy");
            return laFecha;
        }
    }
}