using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gestion_De_Notas.MODEL
{
   
    public class Curso
    {
      
        public int Id { get; set; }

      
        public string NombreCurso { get; set; }

        
        public int CantidadEstudiantes { get; set; }

        public virtual List<Estudiante> Estudiantes { get; set; }
    }
}
