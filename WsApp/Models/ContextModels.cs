using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WsApp.Models
{   
    public class ContextModels:DbContext
    {
        public ContextModels() : base("DefaultConnection")
        {

        }
        public DbSet<User> users { get; set; }
    }
}