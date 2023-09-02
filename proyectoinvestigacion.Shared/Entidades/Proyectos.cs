using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoinvestigacion.Shared.Entidades
{
    public class proyectos
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "El nombre del proyecto es requerido")]
        public string NombrePro { get; set; } = null;
        [Required (ErrorMessage = "la descripción es requerida")]
        public string Descripcion { get; set; } = null;
        public string lider { get; set; } = null; 
        public string Area { get; set; } = null;
        public string FeInicio { get; set; } = null;
        public string FeFinal { get; set; } = null;
    
    }
}
