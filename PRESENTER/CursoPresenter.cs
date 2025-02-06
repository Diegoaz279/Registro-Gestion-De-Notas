using System;
using System.Collections.Generic;
using System.Linq;
using Registro_Gestion_De_Notas.MODEL;
using Registro_Gestion_De_Notas.VIEW;

namespace Registro_Gestion_De_Notas.PRESENTADOR
{
    public class CursoPresentador
    {
        private readonly GestionNotasDBEntities _context;
        private readonly Ivista _vista;

        public CursoPresentador(Ivista vista)
        {
            _context = new GestionNotasDBEntities();
            _vista = vista;
        }

        public void AgregarCurso(string nombreCurso, int cantidadEstudiantes)
        {
            try
            {
                if (cantidadEstudiantes < 1)
                {
                    _vista.MostrarMensaje("La cantidad de estudiantes debe ser mayor a 0.");
                    return;
                }

                var curso = new Cursos { NombreCurso = nombreCurso, CantidadEstudiantes = cantidadEstudiantes };
                _context.Cursos.Add(curso);
                _context.SaveChanges();

                _vista.MostrarMensaje("Curso agregado correctamente.");
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje("Error al agregar curso: " + ex.Message);
            }
        }

        public List<Cursos> ObtenerCursos()
        {
            return _context.Cursos.ToList();
        }
    }
}
