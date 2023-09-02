using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInvestigacion.Shared.Entidades
{
    public class Investigador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; } = null;

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; } = null;

        [Required(ErrorMessage = "Ingrese su tipo de afiliacion")]
        public string AfiliacionInstitucional { get; set; } = null;

        [Required(ErrorMessage = "Debe ingresar su especializacion")]
        public string Especializacion { get; set; } = null;
        public string Rol { get; set; } = null;
        public string NombreCompleto => $"{Nombre} {Apellido}";


    }
}
