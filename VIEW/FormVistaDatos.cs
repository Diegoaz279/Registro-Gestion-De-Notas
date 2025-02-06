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
         private VistaDatosPresentador _presenter;

        public DataGridView DtgVerCurso => dtgVerCurso;
        public FormVistaDatos()
        {
            InitializeComponent();
            _presenter = new VistaDatosPresentador(this);
            _presenter.CargarDatos();
        }

     

        private void FormVistaDatos_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAtrasVer_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormEstudiantes formEstudiantes = new FormEstudiantes();
            formEstudiantes.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
