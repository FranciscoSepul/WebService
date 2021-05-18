using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WsApp.Models
{
    public class EntityGlobal
    {
        [Key]
        [Display(Name = "Identificador")]
        public int Id { get; set; }
        [Display(Name = "Deshabilitado")]
        public string Disabled { get; set; }

        [Display(Name = "Expira")]
        public DateTime? Expires { get; set; }

        [Display(Name = "Registro creado")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "Registro editado")]
        public DateTime? UpdatedAt { get; set; }
        [Display(Name = "Comentario del registro")]
        [StringLength(2000)]
        public string Comments { get; set; }
    }
}