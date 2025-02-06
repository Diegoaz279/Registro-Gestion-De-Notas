using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gestion_De_Notas.MODEL
{
    
    public class Nota
    {
        
        public int Id { get; set; }

       
        public int EstudianteId { get; set; }

        public double Ingles { get; set; }

       
        public double Español { get; set; }

        
        public double Frances { get; set; }

     
        public double Ruso { get; set; }

        public virtual Estudiante Estudiante { get; set; }
    }
}
