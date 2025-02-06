using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Registro_Gestion_De_Notas.MODEL;
using Registro_Gestion_De_Notas.VIEW;

namespace Registro_Gestion_De_Notas.PRESENTADOR
{
    public class CursoPresentador
    {
        // Contexto de la base de datos (Entity Framework)
        private readonly GestionNotasDBEntities _context;

        // Interfaz de la vista para interactuar con la capa de presentación
        private readonly Ivista _vista;

        // Constructor que recibe la vista como parámetro
        public CursoPresentador(Ivista vista)
        {
            // Inicializa el contexto de la base de datos
            _context = new GestionNotasDBEntities();

            // Asigna la vista recibida al campo privado
            _vista = vista;
        }


        public void AgregarCurso(string nombreCurso, int cantidadEstudiantes)
        {
            try
            {
                // Validación: La cantidad de estudiantes debe ser mayor a 0
                if (cantidadEstudiantes < 1)
                {
                    _vista.MostrarMensaje("La cantidad de estudiantes debe ser mayor a 0.");
                    return; // Sale del método si la validación falla
                }

                // Crea un nuevo objeto de tipo Cursos con los datos proporcionados
                var curso = new Cursos
                {
                    NombreCurso = nombreCurso,
                    CantidadEstudiantes = cantidadEstudiantes
                };

                // Agrega el curso al contexto de la base de datos
                _context.Cursos.Add(curso);

                // Guarda los cambios en la base de datos
                _context.SaveChanges();

                // Muestra un mensaje de éxito en la vista
                _vista.MostrarMensaje("Curso agregado correctamente.");
            }
            catch (Exception ex)
            {
                // Si ocurre un error, muestra un mensaje con la excepción
                _vista.MostrarMensaje("Error al agregar curso: " + ex.Message);
            }
        }


        // Método para obtener los cursos en formato DataTable
        public DataTable ObtenerCursos()
        {
            // Paso 1: Obtener los cursos desde la base de datos
            var cursos = _context.Cursos.ToList(); // Convierte la tabla Cursos en una lista

            // Paso 2: Crear un DataTable para almacenar los datos filtrados
            DataTable dtFiltrado = new DataTable();

            // Paso 3: Agregar las columnas necesarias al DataTable
            dtFiltrado.Columns.Add("Id", typeof(int)); // Columna para el ID del curso
            dtFiltrado.Columns.Add("NombreCurso", typeof(string)); // Columna para el nombre del curso
            dtFiltrado.Columns.Add("EstudiantesPorCurso", typeof(int)); // Columna para la cantidad de estudiantes

            // Paso 4: Llenar el DataTable con los datos de la lista de cursos
            foreach (var curso in cursos)
            {
                // Crear una nueva fila en el DataTable
                DataRow row = dtFiltrado.NewRow();

                // Asignar los valores de cada curso a las columnas correspondientes
                row["Id"] = curso.Id; // Usar curso.IdCurso en lugar de curso.Id
                row["NombreCurso"] = curso.NombreCurso;
                row["EstudiantesPorCurso"] = curso.CantidadEstudiantes;

                // Agregar la fila al DataTable
                dtFiltrado.Rows.Add(row);
            }

            // Paso 5: Retornar el DataTable con los datos filtrados
            return dtFiltrado;
        }

    }
}
