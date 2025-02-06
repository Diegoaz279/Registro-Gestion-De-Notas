using Registro_Gestion_De_Notas.PRESENTER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Gestion_De_Notas.VIEW
{
    public partial class FormVistaDatos : Form, IVistaVistaDatos
    {
        private VistaDatosPresentador presentador;
        public FormVistaDatos()
        {
            InitializeComponent();
            presentador = new VistaDatosPresentador(this);
        }

        public DataGridView DtgVerCurso => dtgVerCurso;

        private void FormVistaDatos_Load(object sender, EventArgs e)
        {
            presentador.CargarDatos();
        }

        private void btnAtrasVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEstudiantes formEstudiantes = new FormEstudiantes();
            formEstudiantes.Show();
        }
    }
}
