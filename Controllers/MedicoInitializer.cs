using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCClinica.Data;
using MVCClinica.Models;
namespace MVCClinica.Controllers
{
    public class MedicoInitializer:DropCreateDatabaseAlways<MedicoDBContext>
    {
        protected override void Seed(MedicoDBContext context)
        {
            var medicos = new List<Medico>
            {
               new Medico
               {
                  
                  Nombre = "Antonio",
                  Apellido = "Hernandez",
                  NroMatricula=100,
                  Especialidad="No se sabe"
               }
            };
            medicos.ForEach(b => context.Medicos.Add(b));
            context.SaveChanges();
        }
    }
}