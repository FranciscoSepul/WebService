using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WsApp.Dto;
using WsApp.Interface;
using WsApp.Models;

namespace WsApp.Services
{
    public class PagoService : IPagoInterface
    {
        public CodigosDto Descuento(Descuento descuento)
        {
            CodigosDto codigo = new CodigosDto();
            return codigo;
        }

        public CodigosDto Pago(Pago pago)
        {
            CodigosDto codigo = new CodigosDto();
            using (var db = new ContextModels())
            {
                var tarjeta = db.Tarjetas.FirstOrDefault(x => x.Pan == pago.Pan);
                var User = db.Users.FirstOrDefault(x => x.Id == tarjeta.User.Id);
                if (tarjeta == null)
                {
                    codigo.codigo = 10.ToString();
                    codigo.mensaje = "Tarjeta no existe";
                    return codigo;
                }
                else
                {
                    if (tarjeta.Anovencimiento < DateTime.Now.Year)
                    {
                        codigo.codigo = 14.ToString();
                        codigo.mensaje = "Tarjeta Vencida";
                        return codigo;
                    }
                    else
                    {
                        if (tarjeta.CodigoSeguridad.ToString() != pago.CodigoSeguridad)
                        {
                            codigo.codigo = 13.ToString();
                            codigo.mensaje = "Contraseña incorrecta";
                            return codigo;
                        }
                        else
                        {
                            if (int.Parse(tarjeta.Disabled) ==1)
                            {
                                codigo.codigo = 12.ToString();
                                codigo.mensaje = "Tarjeta Bloqueada";
                                return codigo;
                            }
                            else
                            {
                                if (User.MontoMaximo <= 0)
                                {
                                    codigo.codigo = 11.ToString();
                                    codigo.mensaje = "Falta de fondos";
                                    return codigo;
                                }
                                else
                                {
                                    int ano = tarjeta.Anovencimiento - DateTime.Now.Year;
                                    int mes = tarjeta.MesVencimiento - DateTime.Now.Month;

                                    if (ano <= 0 && mes <= 0)
                                    {
                                        codigo.codigo = 01.ToString();
                                        codigo.mensaje = "Pronta a vencer";
                                        return codigo;
                                    }
                                    else
                                    {

                                        codigo.codigo = 00.ToString();
                                        codigo.mensaje = "Sin incidentes";
                                        return codigo;

                                    }

                                }
                            }
                        }
                    }
                }

            }
        }
    }
}