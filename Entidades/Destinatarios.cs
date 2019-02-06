using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Destinatarios
    {
        [Key]
        public int DestinatarioId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public int Total { get; set; }
        public Destinatarios()
        {
            this.DestinatarioId = 0;
            this.Nombre = string.Empty;
            this.Fecha = DateTime.Now;
            this.Direccion = string.Empty;
            this.Total = 0;
        }
    }

}
