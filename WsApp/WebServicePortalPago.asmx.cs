using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WsApp.Dto;
using WsApp.Interface;
using WsApp.Services;

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
        PagoService _pagoService = new PagoService();

        #region Pago
        [WebMethod(Description = "Servicio Portal Pago")]
        public CodigosDto ServicioPagos(string Pan, string Mes, string Ano, string CodigoSeguridad, string MarcaTarjeta, string Pass)
        {
            PagoService _pagoService = new PagoService();
            try
            {
                CodigosDto codigo = new CodigosDto();
                if (Pan != "" && Mes != "" && Ano != "" && CodigoSeguridad != "" && MarcaTarjeta != "" && Pass != "")
                {
                    Pago pago = new Pago();
                    pago.Pan = Pan;
                    pago.Mes = int.Parse(Mes);
                    pago.Ano = int.Parse(Ano);
                    pago.CodigoSeguridad = CodigoSeguridad;
                    pago.MarcaTarjeta = MarcaTarjeta;
                    pago.Pass = Pass;
                    var Response = _pagoService.Pago(pago);
                    return Response;
                }
                else
                {
                    codigo.codigo = "15";
                    codigo.mensaje = "Datos Erroneos";
                    return codigo;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }
        #endregion

        #region Descuento
        [WebMethod(Description = "Servicio Descuento")]
        public CodigosDto ServicioDescuento(string idCliente, string monto)
        {
            CodigosDto codigo = new CodigosDto();
            if (monto != "" && idCliente != "")
            {
                Descuento descuento = new Descuento();
                descuento.idCliente = idCliente;
                descuento.monto = monto;
                var Response = _pagoService.Descuento(descuento);
                return Response;
            }
            else
            {
                codigo.codigo = "15";
                codigo.mensaje = "Datos Erroneos";
                return codigo;
            }
        }
        #endregion
    }



}
