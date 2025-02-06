using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gestion_De_Notas.MODEL
{
   
    public class Estudiante
    {
        
        public int Id { get; set; }

   
        public string Nombre { get; set; }

     
        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
