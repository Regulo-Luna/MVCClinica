using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCClinica.Models;
using MVCClinica.Data;
namespace MVCClinica.Admin
{
    public static class AdmMedico
    {
        private static MedicoDBContext context = new MedicoDBContext();

        public static List<Medico> Listar() 
        {
            return context.Medicos.ToList();
        }

        public static Medico Listar(int id)
        {
            return context.Medicos.Find(id);
        }
        internal static Medico BuscarPorId(int id)
        {
            Medico medico = context.Medicos.Find(id);
            context.Entry(medico).State = EntityState.Detached;
            return medico;
        }
        internal static void Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            context.SaveChanges();
        }
        internal static void Modificar(Medico medico)
        {
            context.Medicos.Attach(medico);
            context.Entry(medico).State = EntityState.Modified;
            context.SaveChanges();
        }

        internal static void Eliminar(Medico medico)
        {

            context.Medicos.Remove(medico);
            context.SaveChanges();
        }
        public static List<Medico> ListarEspecialidad(string especialidad)
        {
            List<Medico> medicosEspecialidad = (from m in context.Medicos
                                                where m.Especialidad == especialidad
                                                select m).ToList();
            return medicosEspecialidad;
        }
        public static List<Medico> ListarNombre(string nombre, string apellido)
        {
            List<Medico> medicos = (from m in context.Medicos
                                        where m.Nombre == nombre
                                        where m.Apellido == apellido
                                        select m).ToList();
            return medicos;
        }
    
    }
}