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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double[] notas = {
            double.Parse(txtingles.Text),
            double.Parse(txtespañol.Text),
            double.Parse(txtfrances.Text),
            double.Parse(txtruso.Text)
        };

            _presenter.AgregarEstudiante(txtNombreEstudiante.Text, (int)cmbCursos.SelectedValue, notas);
        }
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}
