using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WsApp.Models;

namespace WsApp
{
    public class User : EntityGlobal
    {
        public string Name { get; set; }
        public int MontoMaximo { get; set; }

    }
}