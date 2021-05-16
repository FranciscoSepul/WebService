using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WsApp
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description ="Servicio Portal Pago")]
        public String ServicioPagos(string Pan, string Mes, string Ano, string CodigoSeguridad, string MarcaTarjeta, string Pass)
        {
            return "";
        }

        [WebMethod(Description = "Servicio Descuento")]
        public String ServicioDescuento(string idCliente, string monto)
        {
            return "";
        }
    }

        
    
}
