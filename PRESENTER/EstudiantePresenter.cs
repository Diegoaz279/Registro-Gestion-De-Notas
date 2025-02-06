using Registro_Gestion_De_Notas.MODEL;
using Registro_Gestion_De_Notas.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Registro_Gestion_De_Notas.PRESENTADOR
{
    public class EstudiantePresentador
    {
        private readonly GestionNotasDBEntities _context;
        private readonly Ivista _vista;

        public EstudiantePresentador(Ivista vista)
        {
            _context = new GestionNotasDBEntities();
            _vista = vista;
        }

        public void AgregarEstudiante(string nombre, int cursoId, double[] notas)
        {
            try
            {
                if (notas.Length != 4)
                {
                    _vista.MostrarMensaje("Debe ingresar 4 notas.");
                    return;
                }

                var estudiante = new Estudiantes { Nombre = nombre, CursoId = cursoId };
                _context.Estudiantes.Add(estudiante);
                _context.SaveChanges();

                var nuevaNota = new Notas
                {
                    EstudianteId = estudiante.Id,
                    Ingles = notas[0],
                    Español = notas[1],
                    Frances = notas[2],
                    Ruso = notas[3]
                };
                _context.Notas.Add(nuevaNota);
                _context.SaveChanges();

                _vista.MostrarMensaje("Estudiante y notas agregados correctamente.");
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje("Error al agregar estudiante: " + ex.Message);
            }
        }

        public List<Estudiantes> ObtenerEstudiantes(int cursoId)
        {
            return _context.Estudiantes.Where(e => e.CursoId == cursoId).ToList();
        }
    }
}
