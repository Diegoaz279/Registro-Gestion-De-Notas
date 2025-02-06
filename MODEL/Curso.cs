using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Gestion_De_Notas.MODEL
{

    // Definición de la clase 'Curso' que representa un curso en el sistema
    public class Curso
    {
        // Propiedad que representa el identificador único del curso (Clave primaria)
        public int Id { get; set; }

        // Propiedad que representa el nombre del curso
        public string NombreCurso { get; set; }

        // Propiedad que indica la cantidad de estudiantes inscritos en el curso
        public int CantidadEstudiantes { get; set; }

        // Propiedad de navegación que permite acceder a los estudiantes asociados a este curso
        // 'virtual' permite la carga perezosa (Lazy Loading) de los estudiantes relacionados en una consulta a la base de datos
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
