using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WsApp.Models
{
    public class Tarjetas:EntityGlobal
    {
        public string Pan { get; set; }
        public int MesVencimiento { get; set; }
        public int Anovencimiento { get; set; }
        public int CodigoSeguridad { get; set; }
        public string NombreTarjeta { get; set; }
        public string Pass { get; set; }
        public virtual User User { get; set; }

    }
}