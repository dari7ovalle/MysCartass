using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Cartas
    {
        [Key]
        public int CartasId { get; set; }
        public DateTime Fecha { get; set; }
        public int DestinatarioId { get; set; }
        public string Cuerpo { get; set; }

        public Cartas()
        {
            this.CartasId = 0;
           this.Fecha = DateTime.Now;
            this.DestinatarioId = 0;
            this.Cuerpo = string.Empty;
        }
    }
}
