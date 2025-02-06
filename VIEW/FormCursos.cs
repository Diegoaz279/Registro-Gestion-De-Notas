using Registro_Gestion_De_Notas.PRESENTADOR;
using Registro_Gestion_De_Notas.PRESENTER;
using Registro_Gestion_De_Notas.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Registro_Gestion_De_Notas
{
    public partial class FormCursos : Form, Ivista
    {
        private CursoPresentador _presenter;

        public FormCursos()
        {
            InitializeComponent();
            _presenter = new CursoPresentador(this);
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEstudiantesCursoAgregar.Text, out int cantidadEstudiantes))
            {
                _presenter.AgregarCurso(txtCursoAgregar.Text, cantidadEstudiantes);

                FormEstudiantes frms = new FormEstudiantes();            
                frms.ShowDialog();
            }
            else
            {
                MostrarMensaje("Ingrese un número válido para la cantidad de estudiantes.");
            }
        }
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
