using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cartas> cartas { get; set; }
        public DbSet<Destinatarios> destinatarios { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}