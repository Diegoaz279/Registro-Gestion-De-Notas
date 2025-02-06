using Registro_Gestion_De_Notas.PRESENTADOR;
using Registro_Gestion_De_Notas.PRESENTER;
using Registro_Gestion_De_Notas.VIEW;
using System;
using System.Windows.Forms;

namespace Registro_Gestion_De_Notas
{
    public partial class FormEstudiantes : Form, Ivista
    {
        private EstudiantePresentador _presenter;
        public FormEstudiantes()
        {
            InitializeComponent();
            _presenter = new EstudiantePresentador(this);
            CargarCursos(); //Carga la lista de curso en el cmb
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el nombre del estudiante no esté vacío
                if (string.IsNullOrWhiteSpace(txtNombreEstudiante.Text))
                {
                    MostrarMensaje("El nombre del estudiante no puede estar vacío.");
                    return;
                }

                // Validar que se haya seleccionado un curso
                if (cmbCursos.SelectedValue == null)
                {
                    MostrarMensaje("Debe seleccionar un curso.");
                    return;
                }

                // Validar que las notas sean valores numéricos y estén en el rango de 0 a 100
                double[] notas = new double[4];

                if (!double.TryParse(txtingles.Text, out notas[0]) || notas[0] < 0 || notas[0] > 100 ||
                    !double.TryParse(txtespañol.Text, out notas[1]) || notas[1] < 0 || notas[1] > 100 ||
                    !double.TryParse(txtfrances.Text, out notas[2]) || notas[2] < 0 || notas[2] > 100 ||
                    !double.TryParse(txtruso.Text, out notas[3]) || notas[3] < 0 || notas[3] > 100)
                {
                    MostrarMensaje("No puede dejar campos vacio O Ingrese notas válidas entre 0 y 100.");
                    return;
                }

                // Agregar el estudiante con sus notas
                _presenter.AgregarEstudiante(txtNombreEstudiante.Text, (int)cmbCursos.SelectedValue, notas);
                MostrarMensaje("Estudiante agregado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al agregar estudiante: " + ex.Message);
            }
        }
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void CargarCursos()
        {
            try
            {
                // Cargar los cursos en el ComboBox
                cmbCursos.DataSource = _presenter.ObtenerCursos();
                cmbCursos.DisplayMember = "NombreCurso";
                cmbCursos.ValueMember = "Id";

                // Establecer que no haya selección por defecto
                cmbCursos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al cargar los cursos: " + ex.Message);
            }
        }

        private void btnEstudianteNota_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir el formulario de vista de datos y cerrar este
                this.Dispose();
                FormVistaDatos vistaDatos = new FormVistaDatos();
                vistaDatos.ShowDialog();

            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al abrir el formulario de vista de datos: " + ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            txtespañol.Text = string.Empty;
            txtfrances.Text = string.Empty;
            txtingles.Text = string.Empty;
            txtNombreEstudiante.Text = string.Empty;
            txtruso.Text = string.Empty;
            cmbCursos.SelectedIndex = -1;
        }


        private void btnAtrasNota_Click(object sender, EventArgs e)
        {
            try
            {
                // Volver al formulario de cursos y cerrar este
                this.Dispose();
                FormCursos formCursos = new FormCursos();
                formCursos.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al regresar al formulario de cursos: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
