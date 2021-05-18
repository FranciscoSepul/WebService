using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsApp.Dto
{
    public class Pago
    {
        public string Pan { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string CodigoSeguridad { get; set; }
        public string MarcaTarjeta { get; set; }
        public string Pass { get; set; }
    }
}
