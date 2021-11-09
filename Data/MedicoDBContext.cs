using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCClinica.Models;
namespace MVCClinica.Data
{
    public class MedicoDBContext:DbContext
    {
        public MedicoDBContext() : base("KeyDB") { }

        public DbSet<Medico> Medicos { get; set; }
    }
}