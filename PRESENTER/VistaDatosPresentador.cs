using Registro_Gestion_De_Notas.MODEL;
using Registro_Gestion_De_Notas.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Gestion_De_Notas.PRESENTER
{
    public  class VistaDatosPresentador
    {
        private readonly IVistaVistaDatos vista;
        private readonly GestionNotasDBEntities db;

        public VistaDatosPresentador(IVistaVistaDatos vista)
        {
            this.vista = vista;
            db = new GestionNotasDBEntities();
        }

        public void CargarDatos()
        {
            try
            {
                var listaDatos = db.Estudiantes
                    .Join(db.Notas, e => e.Id, n => n.EstudianteId, (e, n) => new
                    {
                        CursoId = e.CursoId,  // Guardamos el ID del curso
                        Estudiante = e.Nombre,
                        Inglés = n.Ingles,
                        Español = n.Español,
                        Francés = n.Frances,
                        Ruso = n.Ruso
                    })
                    .ToList() // Convertimos a lista para evitar restricciones de EF
                    .Select(x => new
                    {
                        Curso = db.Cursos.FirstOrDefault(c => c.Id == x.CursoId)?.NombreCurso ?? "Sin Curso",
                        x.Estudiante,
                        x.Inglés,
                        x.Español,
                        x.Francés,
                        x.Ruso
                    })
                    .ToList();

                vista.DtgVerCurso.DataSource = listaDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }


    }
}
