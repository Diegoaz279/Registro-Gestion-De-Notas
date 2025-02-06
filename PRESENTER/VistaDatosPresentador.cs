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
                var cursos = db.Cursos.ToList();
                var estudiantes = db.Estudiantes.ToList();
                var notas = db.Notas.ToList();

                List<object[]> listaDatos = new List<object[]>();

                foreach (var curso in cursos)
                {
                    var alumnosCurso = estudiantes.Where(e => e.CursoId == curso.Id).ToList();
                    object[][] notasJagged = new object[alumnosCurso.Count][];

                    for (int i = 0; i < alumnosCurso.Count; i++)
                    {
                        var notaAlumno = notas.FirstOrDefault(n => n.EstudianteId == alumnosCurso[i].Id);
                        if (notaAlumno != null)
                        {
                            notasJagged[i] = new object[] {
                                curso.NombreCurso,
                                alumnosCurso[i].Nombre,
                                notaAlumno.Ingles,
                                notaAlumno.Español,
                                notaAlumno.Frances,
                                notaAlumno.Ruso
                            };
                        }
                    }

                    listaDatos.AddRange(notasJagged);
                }

                vista.DtgVerCurso.DataSource = listaDatos
                    .Select(n => new
                    {
                        Curso = n[0],
                        Estudiante = n[1],
                        Inglés = n[2],
                        Español = n[3],
                        Francés = n[4],
                        Ruso = n[5]
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }
    }
}
