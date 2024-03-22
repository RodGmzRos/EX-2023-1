using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftProductions.SoftProductionsWebService;

namespace SoftProductions
{
    /* Coloque sus datos
        * -------------------------------------------------
        * Nombre Completo:      RODRIGO GOMEZ ROSADO
        * Código PUCP:          20201676
        * Fecha de Modificación: 23/11/2023
    */
    public partial class frmGestionSeries : Form
    {
        private Estado _estado;
        private string _rutaFotoLocal;
        private serieTelevision _serietelevision;
        private SoftProductionsWSClient _daoSoftProductions;
        private director _director;
        public frmGestionSeries()
        {
            InitializeComponent();
            limpiarComponentes();
            _estado = Estado.Inicial;
            _daoSoftProductions = new SoftProductionsWSClient();
            cboProductora.DataSource = _daoSoftProductions.listarTodasProductoras();
            cboProductora.DisplayMember = "nombreProductora";
            cboProductora.ValueMember = "idProductora";

            establecerEstadoComponentes();
        }

        public void limpiarComponentes()
        {
            cboProductora.SelectedIndex = -1;
            pbLogoProductora.Image = null;
            pbPortada.Image = null;
            panelSuperior.BackColor = SystemColors.Control;
            panelInferior.BackColor = SystemColors.Control;
            txtIDSerie.Text = "";
            txtNombreSerie.Text = "";
            nudTemporada.Value = 1;
            dtpFechaEmision.Value = DateTime.Now;
            txtCostoProduccion.Text = "";
            rbEspanhol.Checked = false;
            rbIngles.Checked = false;
            txtSipnosis.Text = "";
            txtNombreCapitulo.Text = "";
            nudNumCapitulo.Value = 1;
            txtDirectorCapitulo.Text = "";
            txtDuracionCapitulo.Text = "";
        }

        private void btnSubirPortada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaFotoLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIDSerie.Enabled = false;
                    txtIDSerie.ReadOnly = true;
                    txtNombreSerie.Enabled = false;
                    txtNombreSerie.ReadOnly = false;
                    cboProductora.Enabled = false;
                    nudTemporada.Enabled = false;
                    dtpFechaEmision.Enabled = false;
                    txtCostoProduccion.Enabled = false;
                    txtCostoProduccion.ReadOnly = false;
                    rbEspanhol.Enabled = false;
                    rbIngles.Enabled = false;
                    txtSipnosis.Enabled = false;
                    txtSipnosis.ReadOnly = false;
                    txtNombreCapitulo.Enabled = false;
                    txtNombreCapitulo.ReadOnly = false;
                    nudNumCapitulo.Enabled = false;
                    txtDirectorCapitulo.Enabled = false;
                    txtDirectorCapitulo.ReadOnly = true;
                    txtDuracionCapitulo.Enabled = false;
                    txtDuracionCapitulo.ReadOnly = false;
                    btnAgregarCapitulo.Enabled = false;
                    btnEliminarCapitulo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDSerie.Enabled = true;
                    txtIDSerie.ReadOnly = true;
                    txtNombreSerie.Enabled = true;
                    txtNombreSerie.ReadOnly = false;
                    cboProductora.Enabled = true;
                    nudTemporada.Enabled = true;
                    dtpFechaEmision.Enabled = true;
                    txtCostoProduccion.Enabled = true;
                    txtCostoProduccion.ReadOnly = false;
                    rbEspanhol.Enabled = true;
                    rbIngles.Enabled = true;
                    txtSipnosis.Enabled = true;
                    txtSipnosis.ReadOnly = false;
                    txtNombreCapitulo.Enabled = true;
                    txtNombreCapitulo.ReadOnly = false;
                    nudNumCapitulo.Enabled = true;
                    txtDirectorCapitulo.Enabled = true;
                    txtDirectorCapitulo.ReadOnly = true;
                    txtDuracionCapitulo.Enabled = true;
                    txtDuracionCapitulo.ReadOnly = false;
                    btnAgregarCapitulo.Enabled = true;
                    btnEliminarCapitulo.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDSerie.Enabled = true;
                    txtIDSerie.ReadOnly = true;
                    txtNombreSerie.Enabled = true;
                    txtNombreSerie.ReadOnly = true;
                    cboProductora.Enabled = false;
                    nudTemporada.Enabled = false;
                    dtpFechaEmision.Enabled = false;
                    txtCostoProduccion.Enabled = true;
                    txtCostoProduccion.ReadOnly = true;
                    rbEspanhol.Enabled = false;
                    rbIngles.Enabled = false;
                    txtSipnosis.Enabled = true;
                    txtSipnosis.ReadOnly = true;
                    txtNombreCapitulo.Enabled = false;
                    txtNombreCapitulo.ReadOnly = false;
                    nudNumCapitulo.Enabled = false;
                    txtDirectorCapitulo.Enabled = false;
                    txtDirectorCapitulo.ReadOnly = true;
                    txtDuracionCapitulo.Enabled = false;
                    txtDuracionCapitulo.ReadOnly = false;
                    btnAgregarCapitulo.Enabled = false;
                    btnEliminarCapitulo.Enabled = false;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarDirector_Click(object sender, EventArgs e)
        {
            frmBusquedaDirectores formBusqEmp = new frmBusquedaDirectores();
            if (formBusqEmp.ShowDialog() == DialogResult.OK)
            {
                _director = formBusqEmp.DirectorSeleccionado;
                txtDirectorCapitulo.Text = _director.nombreDirector + " " + _director.apellidoDirector;
            }
        }
    }
}
