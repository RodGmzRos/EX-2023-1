﻿namespace SoftProductions
{
    partial class frmGestionSeries
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionSeries));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbDatosSerie = new System.Windows.Forms.TabControl();
            this.tpDatosGenerales = new System.Windows.Forms.TabPage();
            this.lblSigno = new System.Windows.Forms.Label();
            this.txtCostoProduccion = new System.Windows.Forms.TextBox();
            this.pbLogoProductora = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.rbEspanhol = new System.Windows.Forms.RadioButton();
            this.txtSipnosis = new System.Windows.Forms.TextBox();
            this.lblSipnosis = new System.Windows.Forms.Label();
            this.rbIngles = new System.Windows.Forms.RadioButton();
            this.lblIdiomaOriginal = new System.Windows.Forms.Label();
            this.lblCostoProduccion = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.nudTemporada = new System.Windows.Forms.NumericUpDown();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lblProductora = new System.Windows.Forms.Label();
            this.cboProductora = new System.Windows.Forms.ComboBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.txtNombreSerie = new System.Windows.Forms.TextBox();
            this.lblNombreSerie = new System.Windows.Forms.Label();
            this.txtIDSerie = new System.Windows.Forms.TextBox();
            this.lblIDSerie = new System.Windows.Forms.Label();
            this.btnSubirPortada = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.tpCapitulosSerie = new System.Windows.Forms.TabPage();
            this.btnEliminarCapitulo = new System.Windows.Forms.Button();
            this.btnAgregarCapitulo = new System.Windows.Forms.Button();
            this.lblDuracionCapitulo = new System.Windows.Forms.Label();
            this.txtDuracionCapitulo = new System.Windows.Forms.TextBox();
            this.btnBuscarDirector = new System.Windows.Forms.Button();
            this.txtDirectorCapitulo = new System.Windows.Forms.TextBox();
            this.txtNombreCapitulo = new System.Windows.Forms.TextBox();
            this.lblDirectorCapitulo = new System.Windows.Forms.Label();
            this.nudNumCapitulo = new System.Windows.Forms.NumericUpDown();
            this.lblNombreCapitulo = new System.Windows.Forms.Label();
            this.lblNroCapitulo = new System.Windows.Forms.Label();
            this.dgvCapitulos = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDelCapitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdPortada = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.tbDatosSerie.SuspendLayout();
            this.tpDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoProductora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemporada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.tpCapitulosSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCapitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1313, 31);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 28);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SoftProductions.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "&Buscar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SoftProductions.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 24);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbDatosSerie
            // 
            this.tbDatosSerie.Controls.Add(this.tpDatosGenerales);
            this.tbDatosSerie.Controls.Add(this.tpCapitulosSerie);
            this.tbDatosSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatosSerie.Location = new System.Drawing.Point(16, 34);
            this.tbDatosSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDatosSerie.Name = "tbDatosSerie";
            this.tbDatosSerie.SelectedIndex = 0;
            this.tbDatosSerie.Size = new System.Drawing.Size(1281, 490);
            this.tbDatosSerie.TabIndex = 1;
            // 
            // tpDatosGenerales
            // 
            this.tpDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosGenerales.Controls.Add(this.lblSigno);
            this.tpDatosGenerales.Controls.Add(this.txtCostoProduccion);
            this.tpDatosGenerales.Controls.Add(this.pbLogoProductora);
            this.tpDatosGenerales.Controls.Add(this.panelInferior);
            this.tpDatosGenerales.Controls.Add(this.rbEspanhol);
            this.tpDatosGenerales.Controls.Add(this.txtSipnosis);
            this.tpDatosGenerales.Controls.Add(this.lblSipnosis);
            this.tpDatosGenerales.Controls.Add(this.rbIngles);
            this.tpDatosGenerales.Controls.Add(this.lblIdiomaOriginal);
            this.tpDatosGenerales.Controls.Add(this.lblCostoProduccion);
            this.tpDatosGenerales.Controls.Add(this.dtpFechaEmision);
            this.tpDatosGenerales.Controls.Add(this.lblFechaEmision);
            this.tpDatosGenerales.Controls.Add(this.nudTemporada);
            this.tpDatosGenerales.Controls.Add(this.lblTemporada);
            this.tpDatosGenerales.Controls.Add(this.lblProductora);
            this.tpDatosGenerales.Controls.Add(this.cboProductora);
            this.tpDatosGenerales.Controls.Add(this.panelSuperior);
            this.tpDatosGenerales.Controls.Add(this.txtNombreSerie);
            this.tpDatosGenerales.Controls.Add(this.lblNombreSerie);
            this.tpDatosGenerales.Controls.Add(this.txtIDSerie);
            this.tpDatosGenerales.Controls.Add(this.lblIDSerie);
            this.tpDatosGenerales.Controls.Add(this.btnSubirPortada);
            this.tpDatosGenerales.Controls.Add(this.pbPortada);
            this.tpDatosGenerales.Location = new System.Drawing.Point(4, 27);
            this.tpDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDatosGenerales.Name = "tpDatosGenerales";
            this.tpDatosGenerales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDatosGenerales.Size = new System.Drawing.Size(1273, 459);
            this.tpDatosGenerales.TabIndex = 0;
            this.tpDatosGenerales.Text = "Datos Generales";
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(637, 224);
            this.lblSigno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(17, 18);
            this.lblSigno.TabIndex = 24;
            this.lblSigno.Text = "$";
            // 
            // txtCostoProduccion
            // 
            this.txtCostoProduccion.Location = new System.Drawing.Point(664, 222);
            this.txtCostoProduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCostoProduccion.Name = "txtCostoProduccion";
            this.txtCostoProduccion.Size = new System.Drawing.Size(177, 24);
            this.txtCostoProduccion.TabIndex = 23;
            // 
            // pbLogoProductora
            // 
            this.pbLogoProductora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogoProductora.Location = new System.Drawing.Point(981, 223);
            this.pbLogoProductora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogoProductora.Name = "pbLogoProductora";
            this.pbLogoProductora.Size = new System.Drawing.Size(263, 93);
            this.pbLogoProductora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoProductora.TabIndex = 21;
            this.pbLogoProductora.TabStop = false;
            // 
            // panelInferior
            // 
            this.panelInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInferior.Location = new System.Drawing.Point(15, 416);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1230, 24);
            this.panelInferior.TabIndex = 20;
            // 
            // rbEspanhol
            // 
            this.rbEspanhol.AutoSize = true;
            this.rbEspanhol.Location = new System.Drawing.Point(733, 252);
            this.rbEspanhol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEspanhol.Name = "rbEspanhol";
            this.rbEspanhol.Size = new System.Drawing.Size(90, 22);
            this.rbEspanhol.TabIndex = 19;
            this.rbEspanhol.TabStop = true;
            this.rbEspanhol.Text = "Español";
            this.rbEspanhol.UseVisualStyleBackColor = true;
            // 
            // txtSipnosis
            // 
            this.txtSipnosis.Location = new System.Drawing.Point(15, 324);
            this.txtSipnosis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSipnosis.Multiline = true;
            this.txtSipnosis.Name = "txtSipnosis";
            this.txtSipnosis.Size = new System.Drawing.Size(1229, 84);
            this.txtSipnosis.TabIndex = 18;
            // 
            // lblSipnosis
            // 
            this.lblSipnosis.AutoSize = true;
            this.lblSipnosis.Location = new System.Drawing.Point(13, 294);
            this.lblSipnosis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSipnosis.Name = "lblSipnosis";
            this.lblSipnosis.Size = new System.Drawing.Size(78, 18);
            this.lblSipnosis.TabIndex = 17;
            this.lblSipnosis.Text = "Sipnosis:";
            // 
            // rbIngles
            // 
            this.rbIngles.AutoSize = true;
            this.rbIngles.Location = new System.Drawing.Point(640, 252);
            this.rbIngles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIngles.Name = "rbIngles";
            this.rbIngles.Size = new System.Drawing.Size(73, 22);
            this.rbIngles.TabIndex = 16;
            this.rbIngles.TabStop = true;
            this.rbIngles.Text = "Inglés";
            this.rbIngles.UseVisualStyleBackColor = true;
            // 
            // lblIdiomaOriginal
            // 
            this.lblIdiomaOriginal.AutoSize = true;
            this.lblIdiomaOriginal.Location = new System.Drawing.Point(484, 254);
            this.lblIdiomaOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdiomaOriginal.Name = "lblIdiomaOriginal";
            this.lblIdiomaOriginal.Size = new System.Drawing.Size(126, 18);
            this.lblIdiomaOriginal.TabIndex = 15;
            this.lblIdiomaOriginal.Text = "Idioma Original:";
            // 
            // lblCostoProduccion
            // 
            this.lblCostoProduccion.AutoSize = true;
            this.lblCostoProduccion.Location = new System.Drawing.Point(440, 223);
            this.lblCostoProduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoProduccion.Name = "lblCostoProduccion";
            this.lblCostoProduccion.Size = new System.Drawing.Size(173, 18);
            this.lblCostoProduccion.TabIndex = 13;
            this.lblCostoProduccion.Text = "Costo de Producción:";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Location = new System.Drawing.Point(639, 187);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(605, 24);
            this.dtpFechaEmision.TabIndex = 12;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(463, 190);
            this.lblFechaEmision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(148, 18);
            this.lblFechaEmision.TabIndex = 11;
            this.lblFechaEmision.Text = "Fecha de Emisión:";
            // 
            // nudTemporada
            // 
            this.nudTemporada.Location = new System.Drawing.Point(639, 154);
            this.nudTemporada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudTemporada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTemporada.Name = "nudTemporada";
            this.nudTemporada.Size = new System.Drawing.Size(133, 24);
            this.nudTemporada.TabIndex = 10;
            this.nudTemporada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Location = new System.Drawing.Point(519, 156);
            this.lblTemporada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(98, 18);
            this.lblTemporada.TabIndex = 9;
            this.lblTemporada.Text = "Temporada:";
            // 
            // lblProductora
            // 
            this.lblProductora.AutoSize = true;
            this.lblProductora.Location = new System.Drawing.Point(523, 126);
            this.lblProductora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductora.Name = "lblProductora";
            this.lblProductora.Size = new System.Drawing.Size(97, 18);
            this.lblProductora.TabIndex = 8;
            this.lblProductora.Text = "Productora:";
            // 
            // cboProductora
            // 
            this.cboProductora.FormattingEnabled = true;
            this.cboProductora.Location = new System.Drawing.Point(639, 121);
            this.cboProductora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProductora.Name = "cboProductora";
            this.cboProductora.Size = new System.Drawing.Size(605, 26);
            this.cboProductora.TabIndex = 7;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Location = new System.Drawing.Point(436, 20);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(809, 30);
            this.panelSuperior.TabIndex = 6;
            // 
            // txtNombreSerie
            // 
            this.txtNombreSerie.Location = new System.Drawing.Point(639, 87);
            this.txtNombreSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreSerie.Name = "txtNombreSerie";
            this.txtNombreSerie.Size = new System.Drawing.Size(605, 24);
            this.txtNombreSerie.TabIndex = 5;
            // 
            // lblNombreSerie
            // 
            this.lblNombreSerie.AutoSize = true;
            this.lblNombreSerie.Location = new System.Drawing.Point(449, 92);
            this.lblNombreSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSerie.Name = "lblNombreSerie";
            this.lblNombreSerie.Size = new System.Drawing.Size(158, 18);
            this.lblNombreSerie.TabIndex = 4;
            this.lblNombreSerie.Text = "Nombre de la Serie:";
            // 
            // txtIDSerie
            // 
            this.txtIDSerie.Location = new System.Drawing.Point(639, 58);
            this.txtIDSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDSerie.Name = "txtIDSerie";
            this.txtIDSerie.Size = new System.Drawing.Size(132, 24);
            this.txtIDSerie.TabIndex = 3;
            this.txtIDSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDSerie
            // 
            this.lblIDSerie.AutoSize = true;
            this.lblIDSerie.Location = new System.Drawing.Point(499, 64);
            this.lblIDSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDSerie.Name = "lblIDSerie";
            this.lblIDSerie.Size = new System.Drawing.Size(114, 18);
            this.lblIDSerie.TabIndex = 2;
            this.lblIDSerie.Text = "ID de la Serie:";
            // 
            // btnSubirPortada
            // 
            this.btnSubirPortada.BackgroundImage = global::SoftProductions.Properties.Resources.Upload;
            this.btnSubirPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirPortada.Location = new System.Drawing.Point(373, 245);
            this.btnSubirPortada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubirPortada.Name = "btnSubirPortada";
            this.btnSubirPortada.Size = new System.Drawing.Size(49, 41);
            this.btnSubirPortada.TabIndex = 1;
            this.btnSubirPortada.UseVisualStyleBackColor = true;
            this.btnSubirPortada.Click += new System.EventHandler(this.btnSubirPortada_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(15, 20);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(407, 265);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // tpCapitulosSerie
            // 
            this.tpCapitulosSerie.BackColor = System.Drawing.SystemColors.Control;
            this.tpCapitulosSerie.Controls.Add(this.btnEliminarCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.btnAgregarCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.lblDuracionCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.txtDuracionCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.btnBuscarDirector);
            this.tpCapitulosSerie.Controls.Add(this.txtDirectorCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.txtNombreCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.lblDirectorCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.nudNumCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.lblNombreCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.lblNroCapitulo);
            this.tpCapitulosSerie.Controls.Add(this.dgvCapitulos);
            this.tpCapitulosSerie.Location = new System.Drawing.Point(4, 27);
            this.tpCapitulosSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCapitulosSerie.Name = "tpCapitulosSerie";
            this.tpCapitulosSerie.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCapitulosSerie.Size = new System.Drawing.Size(1273, 459);
            this.tpCapitulosSerie.TabIndex = 1;
            this.tpCapitulosSerie.Text = "Capítulos de la Serie";
            // 
            // btnEliminarCapitulo
            // 
            this.btnEliminarCapitulo.Location = new System.Drawing.Point(1196, 108);
            this.btnEliminarCapitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCapitulo.Name = "btnEliminarCapitulo";
            this.btnEliminarCapitulo.Size = new System.Drawing.Size(55, 28);
            this.btnEliminarCapitulo.TabIndex = 12;
            this.btnEliminarCapitulo.Text = "-";
            this.btnEliminarCapitulo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCapitulo
            // 
            this.btnAgregarCapitulo.Location = new System.Drawing.Point(1137, 108);
            this.btnAgregarCapitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCapitulo.Name = "btnAgregarCapitulo";
            this.btnAgregarCapitulo.Size = new System.Drawing.Size(55, 28);
            this.btnAgregarCapitulo.TabIndex = 11;
            this.btnAgregarCapitulo.Text = "+";
            this.btnAgregarCapitulo.UseVisualStyleBackColor = true;
            // 
            // lblDuracionCapitulo
            // 
            this.lblDuracionCapitulo.AutoSize = true;
            this.lblDuracionCapitulo.Location = new System.Drawing.Point(21, 113);
            this.lblDuracionCapitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracionCapitulo.Name = "lblDuracionCapitulo";
            this.lblDuracionCapitulo.Size = new System.Drawing.Size(175, 18);
            this.lblDuracionCapitulo.TabIndex = 10;
            this.lblDuracionCapitulo.Text = "Duración del Capítulo:";
            // 
            // txtDuracionCapitulo
            // 
            this.txtDuracionCapitulo.Location = new System.Drawing.Point(229, 110);
            this.txtDuracionCapitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuracionCapitulo.Name = "txtDuracionCapitulo";
            this.txtDuracionCapitulo.Size = new System.Drawing.Size(132, 24);
            this.txtDuracionCapitulo.TabIndex = 9;
            // 
            // btnBuscarDirector
            // 
            this.btnBuscarDirector.BackgroundImage = global::SoftProductions.Properties.Resources.Search;
            this.btnBuscarDirector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarDirector.Location = new System.Drawing.Point(928, 78);
            this.btnBuscarDirector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarDirector.Name = "btnBuscarDirector";
            this.btnBuscarDirector.Size = new System.Drawing.Size(33, 28);
            this.btnBuscarDirector.TabIndex = 8;
            this.btnBuscarDirector.UseVisualStyleBackColor = true;
            this.btnBuscarDirector.Click += new System.EventHandler(this.btnBuscarDirector_Click);
            // 
            // txtDirectorCapitulo
            // 
            this.txtDirectorCapitulo.Location = new System.Drawing.Point(229, 79);
            this.txtDirectorCapitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDirectorCapitulo.Name = "txtDirectorCapitulo";
            this.txtDirectorCapitulo.ReadOnly = true;
            this.txtDirectorCapitulo.Size = new System.Drawing.Size(695, 24);
            this.txtDirectorCapitulo.TabIndex = 6;
            // 
            // txtNombreCapitulo
            // 
            this.txtNombreCapitulo.Location = new System.Drawing.Point(229, 48);
            this.txtNombreCapitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCapitulo.Name = "txtNombreCapitulo";
            this.txtNombreCapitulo.Size = new System.Drawing.Size(695, 24);
            this.txtNombreCapitulo.TabIndex = 5;
            // 
            // lblDirectorCapitulo
            // 
            this.lblDirectorCapitulo.AutoSize = true;
            this.lblDirectorCapitulo.Location = new System.Drawing.Point(31, 82);
            this.lblDirectorCapitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirectorCapitulo.Name = "lblDirectorCapitulo";
            this.lblDirectorCapitulo.Size = new System.Drawing.Size(168, 18);
            this.lblDirectorCapitulo.TabIndex = 4;
            this.lblDirectorCapitulo.Text = "Director del Capítulo:";
            // 
            // nudNumCapitulo
            // 
            this.nudNumCapitulo.Location = new System.Drawing.Point(229, 16);
            this.nudNumCapitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNumCapitulo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumCapitulo.Name = "nudNumCapitulo";
            this.nudNumCapitulo.Size = new System.Drawing.Size(116, 24);
            this.nudNumCapitulo.TabIndex = 3;
            this.nudNumCapitulo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNombreCapitulo
            // 
            this.lblNombreCapitulo.AutoSize = true;
            this.lblNombreCapitulo.Location = new System.Drawing.Point(31, 52);
            this.lblNombreCapitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCapitulo.Name = "lblNombreCapitulo";
            this.lblNombreCapitulo.Size = new System.Drawing.Size(167, 18);
            this.lblNombreCapitulo.TabIndex = 2;
            this.lblNombreCapitulo.Text = "Nombre del Capítulo:";
            // 
            // lblNroCapitulo
            // 
            this.lblNroCapitulo.AutoSize = true;
            this.lblNroCapitulo.Location = new System.Drawing.Point(77, 18);
            this.lblNroCapitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroCapitulo.Name = "lblNroCapitulo";
            this.lblNroCapitulo.Size = new System.Drawing.Size(126, 18);
            this.lblNroCapitulo.TabIndex = 1;
            this.lblNroCapitulo.Text = "N° del Capítulo:";
            // 
            // dgvCapitulos
            // 
            this.dgvCapitulos.AllowUserToAddRows = false;
            this.dgvCapitulos.AllowUserToDeleteRows = false;
            this.dgvCapitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapitulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.NombreDelCapitulo,
            this.Director,
            this.Duración});
            this.dgvCapitulos.Location = new System.Drawing.Point(20, 148);
            this.dgvCapitulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCapitulos.Name = "dgvCapitulos";
            this.dgvCapitulos.ReadOnly = true;
            this.dgvCapitulos.RowHeadersWidth = 51;
            this.dgvCapitulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCapitulos.Size = new System.Drawing.Size(1229, 295);
            this.dgvCapitulos.TabIndex = 0;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "N° del Capítulo";
            this.Nro.MinimumWidth = 6;
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 130;
            // 
            // NombreDelCapitulo
            // 
            this.NombreDelCapitulo.HeaderText = "Nombre del Capítulo";
            this.NombreDelCapitulo.MinimumWidth = 6;
            this.NombreDelCapitulo.Name = "NombreDelCapitulo";
            this.NombreDelCapitulo.ReadOnly = true;
            this.NombreDelCapitulo.Width = 370;
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.MinimumWidth = 6;
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            this.Director.Width = 250;
            // 
            // Duración
            // 
            this.Duración.HeaderText = "Duración";
            this.Duración.MinimumWidth = 6;
            this.Duración.Name = "Duración";
            this.Duración.ReadOnly = true;
            this.Duración.Width = 125;
            // 
            // ofdPortada
            // 
            this.ofdPortada.FileName = "ofdPortada";
            // 
            // frmGestionSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 533);
            this.Controls.Add(this.tbDatosSerie);
            this.Controls.Add(this.tsMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionSeries";
            this.Text = "Formulario de Gestión de Series de Televisión";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tbDatosSerie.ResumeLayout(false);
            this.tpDatosGenerales.ResumeLayout(false);
            this.tpDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoProductora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemporada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.tpCapitulosSerie.ResumeLayout(false);
            this.tpCapitulosSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCapitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.TabControl tbDatosSerie;
        private System.Windows.Forms.TabPage tpDatosGenerales;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.TabPage tpCapitulosSerie;
        private System.Windows.Forms.Button btnSubirPortada;
        private System.Windows.Forms.TextBox txtIDSerie;
        private System.Windows.Forms.Label lblIDSerie;
        private System.Windows.Forms.TextBox txtNombreSerie;
        private System.Windows.Forms.Label lblNombreSerie;
        private System.Windows.Forms.OpenFileDialog ofdPortada;
        private System.Windows.Forms.Label lblProductora;
        private System.Windows.Forms.ComboBox cboProductora;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.NumericUpDown nudTemporada;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.RadioButton rbIngles;
        private System.Windows.Forms.Label lblIdiomaOriginal;
        private System.Windows.Forms.Label lblCostoProduccion;
        private System.Windows.Forms.RadioButton rbEspanhol;
        private System.Windows.Forms.TextBox txtSipnosis;
        private System.Windows.Forms.Label lblSipnosis;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.PictureBox pbLogoProductora;
        private System.Windows.Forms.DataGridView dgvCapitulos;
        private System.Windows.Forms.Button btnBuscarDirector;
        private System.Windows.Forms.TextBox txtDirectorCapitulo;
        private System.Windows.Forms.TextBox txtNombreCapitulo;
        private System.Windows.Forms.Label lblDirectorCapitulo;
        private System.Windows.Forms.NumericUpDown nudNumCapitulo;
        private System.Windows.Forms.Label lblNombreCapitulo;
        private System.Windows.Forms.Label lblNroCapitulo;
        private System.Windows.Forms.Label lblDuracionCapitulo;
        private System.Windows.Forms.TextBox txtDuracionCapitulo;
        private System.Windows.Forms.Button btnEliminarCapitulo;
        private System.Windows.Forms.Button btnAgregarCapitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDelCapitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duración;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.TextBox txtCostoProduccion;
    }
}

