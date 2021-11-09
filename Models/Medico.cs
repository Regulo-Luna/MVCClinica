using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCClinica.Models
{
    [Table("Medico")]
    public class Medico
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Es obligatorio escribir Nombre")]
        [StringLength(50,ErrorMessage ="Solo puede tener maximo 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Es obligatorio escribir Apellido")]
        [StringLength(50, ErrorMessage = "Solo puede tener maximo 50 caracteres")]
        public string Apellido { get; set; }
        [Required(ErrorMessage ="Es obligatorio escribir la especialidad")]
        [StringLength(20, ErrorMessage = "Solo puede tener maximo 20 caracteres")]

        public string Especialidad { get; set; }
        [Required(ErrorMessage ="Es obligatorio escribir numero de matricula")]
        [DisplayName("Número de matrícula")]
        public int NroMatricula { get; set; }

    }
}