using SoftProductions.SoftProductionsWebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftProductions
{
    public partial class frmBusquedaDirectores : Form
    {
        private SoftProductionsWSClient _daoSoftProductions;
        private director _directorSeleccionado;

        public director DirectorSeleccionado { get => _directorSeleccionado; set => _directorSeleccionado = value; }
        public frmBusquedaDirectores()
        {
            _daoSoftProductions = new SoftProductionsWSClient();
            InitializeComponent();
            dgvDirectores.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDirectores.DataSource =
                _daoSoftProductions.listarDirectoresXNombre
                (txtNombre.Text).ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DirectorSeleccionado = (director)dgvDirectores.CurrentRow.
                DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvDirectores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            director director = (director)dgvDirectores.Rows[e.RowIndex].DataBoundItem;
            dgvDirectores.Rows[e.RowIndex].Cells[0].Value = director.nombreDirector + " " +director.apellidoDirector;
            dgvDirectores.Rows[e.RowIndex].Cells[1].Value = director.nacionalidad;
        }
    }
}
