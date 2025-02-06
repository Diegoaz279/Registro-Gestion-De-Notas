using Registro_Gestion_De_Notas.MODEL;
using Registro_Gestion_De_Notas.PRESENTADOR;
using Registro_Gestion_De_Notas.PRESENTER;
using Registro_Gestion_De_Notas.VIEW;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Registro_Gestion_De_Notas
{
    public partial class FormCursos : Form, Ivista
    {
        private CursoPresentador _presenter;

        public FormCursos()
        {
            InitializeComponent();
            _presenter = new CursoPresentador(this);
            CargarCursos();
            LimpiarCampos();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo del curso no esté vacío
                if (string.IsNullOrWhiteSpace(txtCursoAgregar.Text))
                {
                    MostrarMensaje("El nombre del curso no puede estar vacío.");
                    return;
                }

                // Validar que el número de estudiantes sea un número válido
                if (!int.TryParse(txtEstudiantesCursoAgregar.Text, out int cantidadEstudiantes) || cantidadEstudiantes <= 0)
                {
                    MostrarMensaje("Ingrese un número válido para la cantidad de estudiantes.");
                    return;
                }

                // Llamar al presentador para agregar el curso
                _presenter.AgregarCurso(txtCursoAgregar.Text, cantidadEstudiantes);
                CargarCursos(); // Recargar la lista de cursos después de agregar uno nuevo
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error al agregar el curso: " + ex.Message);
            }
        }
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Carga la lista de cursos en el DataGridView
        public void CargarCursos()
        {
            dtgAgregarCurso.DataSource = _presenter.ObtenerCursos();
        }
        public void LimpiarCampos()
        {
            // Limpiar los campos de texto
            txtCursoAgregar.Text = string.Empty;
            txtEstudiantesCursoAgregar.Text = string.Empty;
        }

        private void btnEstudianteNota_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEstudiantes estudiantes = new FormEstudiantes();
            estudiantes.ShowDialog();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
