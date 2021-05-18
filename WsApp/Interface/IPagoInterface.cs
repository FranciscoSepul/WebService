using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WsApp.Dto;

namespace WsApp.Interface
{
    public interface IPagoInterface
    {
        CodigosDto Pago(Pago pago);
        CodigosDto Descuento(Descuento descuento);
    }
}
