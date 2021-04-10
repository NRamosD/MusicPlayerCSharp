namespace ReproductorVideo
{
    partial class frmVideo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideo));
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblTranscurrido = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.tbVolumen = new XComponent.SliderBar.MACTrackBar();
            this.tbProgreso = new XComponent.SliderBar.MACTrackBar();
            this.btnSilenciar = new FontAwesome.Sharp.IconButton();
            this.btnVolumen = new FontAwesome.Sharp.IconButton();
            this.btnParar = new FontAwesome.Sharp.IconButton();
            this.btnAnterior = new FontAwesome.Sharp.IconButton();
            this.btnLista = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnPausar = new FontAwesome.Sharp.IconButton();
            this.btnIniciarReanudar = new FontAwesome.Sharp.IconButton();
            this.wmpPantalla = new AxWMPLib.AxWindowsMediaPlayer();
            this.TiempoReproduccion = new System.Windows.Forms.Timer(this.components);
            this.lbListadoVideos = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelListaVideos = new System.Windows.Forms.Panel();
            this.panelListaReproduccion = new System.Windows.Forms.Panel();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblListaReproduccion = new System.Windows.Forms.Label();
            this.panelOpcionesListaVideos = new System.Windows.Forms.Panel();
            this.btnAñadorVideos = new FontAwesome.Sharp.IconButton();
            this.btnNuevaListaVideos = new FontAwesome.Sharp.IconButton();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPantalla)).BeginInit();
            this.panelListaVideos.SuspendLayout();
            this.panelListaReproduccion.SuspendLayout();
            this.panelOpcionesListaVideos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(50)))));
            this.panelOpciones.Controls.Add(this.lblVolumen);
            this.panelOpciones.Controls.Add(this.lblTranscurrido);
            this.panelOpciones.Controls.Add(this.lblDuracion);
            this.panelOpciones.Controls.Add(this.tbVolumen);
            this.panelOpciones.Controls.Add(this.tbProgreso);
            this.panelOpciones.Controls.Add(this.btnSilenciar);
            this.panelOpciones.Controls.Add(this.btnVolumen);
            this.panelOpciones.Controls.Add(this.btnParar);
            this.panelOpciones.Controls.Add(this.btnAnterior);
            this.panelOpciones.Controls.Add(this.btnLista);
            this.panelOpciones.Controls.Add(this.btnSiguiente);
            this.panelOpciones.Controls.Add(this.btnPausar);
            this.panelOpciones.Controls.Add(this.btnIniciarReanudar);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpciones.Location = new System.Drawing.Point(0, 342);
            this.panelOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(912, 117);
            this.panelOpciones.TabIndex = 0;
            // 
            // lblVolumen
            // 
            this.lblVolumen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.ForeColor = System.Drawing.Color.White;
            this.lblVolumen.Location = new System.Drawing.Point(211, 67);
            this.lblVolumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(61, 23);
            this.lblVolumen.TabIndex = 4;
            this.lblVolumen.Text = "100%";
            // 
            // lblTranscurrido
            // 
            this.lblTranscurrido.AutoSize = true;
            this.lblTranscurrido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranscurrido.ForeColor = System.Drawing.Color.White;
            this.lblTranscurrido.Location = new System.Drawing.Point(16, 40);
            this.lblTranscurrido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranscurrido.Name = "lblTranscurrido";
            this.lblTranscurrido.Size = new System.Drawing.Size(59, 23);
            this.lblTranscurrido.TabIndex = 4;
            this.lblTranscurrido.Text = "00:00";
            // 
            // lblDuracion
            // 
            this.lblDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(1713, 47);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(86, 23);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "00:00:00";
            this.lblDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbVolumen
            // 
            this.tbVolumen.BackColor = System.Drawing.Color.Transparent;
            this.tbVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVolumen.ForeColor = System.Drawing.Color.Blue;
            this.tbVolumen.IndentHeight = 6;
            this.tbVolumen.Location = new System.Drawing.Point(64, 61);
            this.tbVolumen.Margin = new System.Windows.Forms.Padding(4);
            this.tbVolumen.Maximum = 100;
            this.tbVolumen.Minimum = 0;
            this.tbVolumen.Name = "tbVolumen";
            this.tbVolumen.Size = new System.Drawing.Size(151, 28);
            this.tbVolumen.TabIndex = 3;
            this.tbVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolumen.TickColor = System.Drawing.Color.Blue;
            this.tbVolumen.TickHeight = 4;
            this.tbVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolumen.TrackerColor = System.Drawing.Color.Blue;
            this.tbVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.tbVolumen.TrackLineColor = System.Drawing.Color.SlateBlue;
            this.tbVolumen.TrackLineHeight = 3;
            this.tbVolumen.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.tbVolumen.Value = 0;
            this.tbVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.tbVolumen_ValueChanged);
            // 
            // tbProgreso
            // 
            this.tbProgreso.BackColor = System.Drawing.Color.Transparent;
            this.tbProgreso.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbProgreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbProgreso.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProgreso.ForeColor = System.Drawing.Color.Blue;
            this.tbProgreso.IndentHeight = 6;
            this.tbProgreso.Location = new System.Drawing.Point(0, 0);
            this.tbProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.tbProgreso.Maximum = 100;
            this.tbProgreso.Minimum = 0;
            this.tbProgreso.Name = "tbProgreso";
            this.tbProgreso.Size = new System.Drawing.Size(912, 28);
            this.tbProgreso.TabIndex = 2;
            this.tbProgreso.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.tbProgreso.TickColor = System.Drawing.Color.Blue;
            this.tbProgreso.TickHeight = 4;
            this.tbProgreso.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbProgreso.TrackerColor = System.Drawing.Color.Blue;
            this.tbProgreso.TrackerSize = new System.Drawing.Size(16, 16);
            this.tbProgreso.TrackLineColor = System.Drawing.Color.SlateBlue;
            this.tbProgreso.TrackLineHeight = 3;
            this.tbProgreso.TrackLineSelectedColor = System.Drawing.Color.Blue;
            this.tbProgreso.Value = 0;
            this.tbProgreso.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.tbProgreso_ValueChanged);
            // 
            // btnSilenciar
            // 
            this.btnSilenciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSilenciar.BackColor = System.Drawing.Color.Transparent;
            this.btnSilenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSilenciar.FlatAppearance.BorderSize = 0;
            this.btnSilenciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSilenciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSilenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilenciar.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            this.btnSilenciar.IconColor = System.Drawing.Color.IndianRed;
            this.btnSilenciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSilenciar.IconSize = 25;
            this.btnSilenciar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSilenciar.Location = new System.Drawing.Point(21, 67);
            this.btnSilenciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSilenciar.Name = "btnSilenciar";
            this.btnSilenciar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnSilenciar.Size = new System.Drawing.Size(40, 37);
            this.btnSilenciar.TabIndex = 0;
            this.btnSilenciar.UseVisualStyleBackColor = false;
            this.btnSilenciar.Visible = false;
            this.btnSilenciar.Click += new System.EventHandler(this.btnSilenciar_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolumen.BackColor = System.Drawing.Color.Transparent;
            this.btnVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolumen.FlatAppearance.BorderSize = 0;
            this.btnVolumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVolumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumen.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.btnVolumen.IconColor = System.Drawing.Color.Cornsilk;
            this.btnVolumen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolumen.IconSize = 25;
            this.btnVolumen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolumen.Location = new System.Drawing.Point(16, 69);
            this.btnVolumen.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnVolumen.Size = new System.Drawing.Size(40, 37);
            this.btnVolumen.TabIndex = 0;
            this.btnVolumen.UseVisualStyleBackColor = false;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // btnParar
            // 
            this.btnParar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParar.BackColor = System.Drawing.Color.Transparent;
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.FlatAppearance.BorderSize = 0;
            this.btnParar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnParar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnParar.IconColor = System.Drawing.Color.Cornsilk;
            this.btnParar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParar.IconSize = 25;
            this.btnParar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParar.Location = new System.Drawing.Point(996, 74);
            this.btnParar.Margin = new System.Windows.Forms.Padding(4);
            this.btnParar.Name = "btnParar";
            this.btnParar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnParar.Size = new System.Drawing.Size(40, 37);
            this.btnParar.TabIndex = 0;
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            this.btnAnterior.IconColor = System.Drawing.Color.Cornsilk;
            this.btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnterior.IconSize = 25;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnterior.Location = new System.Drawing.Point(921, 76);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnAnterior.Size = new System.Drawing.Size(40, 37);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnLista
            // 
            this.btnLista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLista.BackColor = System.Drawing.Color.Transparent;
            this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.btnLista.IconColor = System.Drawing.Color.Cornsilk;
            this.btnLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLista.IconSize = 25;
            this.btnLista.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLista.Location = new System.Drawing.Point(1193, 76);
            this.btnLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnLista.Name = "btnLista";
            this.btnLista.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnLista.Size = new System.Drawing.Size(40, 37);
            this.btnLista.TabIndex = 0;
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.btnSiguiente.IconColor = System.Drawing.Color.Cornsilk;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 25;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiguiente.Location = new System.Drawing.Point(1125, 76);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnSiguiente.Size = new System.Drawing.Size(40, 37);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPausar.BackColor = System.Drawing.Color.Transparent;
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.FlatAppearance.BorderSize = 0;
            this.btnPausar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPausar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.btnPausar.IconColor = System.Drawing.Color.Cornsilk;
            this.btnPausar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPausar.IconSize = 25;
            this.btnPausar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPausar.Location = new System.Drawing.Point(815, 67);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnPausar.Size = new System.Drawing.Size(40, 37);
            this.btnPausar.TabIndex = 0;
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Visible = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnIniciarReanudar
            // 
            this.btnIniciarReanudar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIniciarReanudar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarReanudar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarReanudar.FlatAppearance.BorderSize = 0;
            this.btnIniciarReanudar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIniciarReanudar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnIniciarReanudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarReanudar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnIniciarReanudar.IconColor = System.Drawing.Color.Cornsilk;
            this.btnIniciarReanudar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarReanudar.IconSize = 25;
            this.btnIniciarReanudar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciarReanudar.Location = new System.Drawing.Point(1061, 74);
            this.btnIniciarReanudar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarReanudar.Name = "btnIniciarReanudar";
            this.btnIniciarReanudar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnIniciarReanudar.Size = new System.Drawing.Size(40, 37);
            this.btnIniciarReanudar.TabIndex = 0;
            this.btnIniciarReanudar.UseVisualStyleBackColor = false;
            this.btnIniciarReanudar.Click += new System.EventHandler(this.btnIniciarReanudar_Click);
            // 
            // wmpPantalla
            // 
            this.wmpPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpPantalla.Enabled = true;
            this.wmpPantalla.Location = new System.Drawing.Point(0, 0);
            this.wmpPantalla.Margin = new System.Windows.Forms.Padding(4);
            this.wmpPantalla.Name = "wmpPantalla";
            this.wmpPantalla.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPantalla.OcxState")));
            this.wmpPantalla.Size = new System.Drawing.Size(912, 459);
            this.wmpPantalla.TabIndex = 1;
            this.wmpPantalla.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpPantalla_PlayStateChange);
            this.wmpPantalla.MouseUpEvent += new AxWMPLib._WMPOCXEvents_MouseUpEventHandler(this.wmpPantalla_MouseUpEvent);
            this.wmpPantalla.Enter += new System.EventHandler(this.wmpPantalla_Enter);
            // 
            // TiempoReproduccion
            // 
            this.TiempoReproduccion.Interval = 1;
            this.TiempoReproduccion.Tick += new System.EventHandler(this.TiempoReproduccion_Tick);
            // 
            // lbListadoVideos
            // 
            this.lbListadoVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(50)))));
            this.lbListadoVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbListadoVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbListadoVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListadoVideos.FormattingEnabled = true;
            this.lbListadoVideos.ItemHeight = 20;
            this.lbListadoVideos.Location = new System.Drawing.Point(0, 124);
            this.lbListadoVideos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbListadoVideos.Name = "lbListadoVideos";
            this.lbListadoVideos.Size = new System.Drawing.Size(400, 181);
            this.lbListadoVideos.TabIndex = 2;
            this.lbListadoVideos.SelectedIndexChanged += new System.EventHandler(this.lbListadoVideos_SelectedIndexChanged);
            this.lbListadoVideos.MouseLeave += new System.EventHandler(this.lbVideos_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(9, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 32);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "--";
            // 
            // panelListaVideos
            // 
            this.panelListaVideos.BackColor = System.Drawing.Color.Black;
            this.panelListaVideos.Controls.Add(this.lbListadoVideos);
            this.panelListaVideos.Controls.Add(this.panelListaReproduccion);
            this.panelListaVideos.Controls.Add(this.panelOpcionesListaVideos);
            this.panelListaVideos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelListaVideos.Location = new System.Drawing.Point(512, 0);
            this.panelListaVideos.Margin = new System.Windows.Forms.Padding(4);
            this.panelListaVideos.Name = "panelListaVideos";
            this.panelListaVideos.Size = new System.Drawing.Size(400, 342);
            this.panelListaVideos.TabIndex = 4;
            this.panelListaVideos.Visible = false;
            this.panelListaVideos.MouseLeave += new System.EventHandler(this.panelListaVideos_MouseLeave);
            // 
            // panelListaReproduccion
            // 
            this.panelListaReproduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(50)))));
            this.panelListaReproduccion.Controls.Add(this.tbBusca);
            this.panelListaReproduccion.Controls.Add(this.btnBusca);
            this.panelListaReproduccion.Controls.Add(this.lblListaReproduccion);
            this.panelListaReproduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListaReproduccion.Location = new System.Drawing.Point(0, 0);
            this.panelListaReproduccion.Margin = new System.Windows.Forms.Padding(4);
            this.panelListaReproduccion.Name = "panelListaReproduccion";
            this.panelListaReproduccion.Size = new System.Drawing.Size(400, 124);
            this.panelListaReproduccion.TabIndex = 5;
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(189, 46);
            this.tbBusca.Margin = new System.Windows.Forms.Padding(4);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(193, 22);
            this.tbBusca.TabIndex = 6;
            this.tbBusca.Text = "Ingrese nombre de la canción";
            this.tbBusca.Click += new System.EventHandler(this.tbBusca_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.Transparent;
            this.btnBusca.FlatAppearance.BorderSize = 2;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.Location = new System.Drawing.Point(270, 78);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(103, 36);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblListaReproduccion
            // 
            this.lblListaReproduccion.AutoSize = true;
            this.lblListaReproduccion.BackColor = System.Drawing.Color.Transparent;
            this.lblListaReproduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaReproduccion.ForeColor = System.Drawing.Color.White;
            this.lblListaReproduccion.Location = new System.Drawing.Point(16, 11);
            this.lblListaReproduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaReproduccion.Name = "lblListaReproduccion";
            this.lblListaReproduccion.Size = new System.Drawing.Size(273, 31);
            this.lblListaReproduccion.TabIndex = 4;
            this.lblListaReproduccion.Text = "Lista de reproducción";
            this.lblListaReproduccion.Click += new System.EventHandler(this.lblListaReproduccion_Click);
            // 
            // panelOpcionesListaVideos
            // 
            this.panelOpcionesListaVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(1)))), ((int)(((byte)(50)))));
            this.panelOpcionesListaVideos.Controls.Add(this.btnAñadorVideos);
            this.panelOpcionesListaVideos.Controls.Add(this.btnNuevaListaVideos);
            this.panelOpcionesListaVideos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpcionesListaVideos.Location = new System.Drawing.Point(0, 305);
            this.panelOpcionesListaVideos.Margin = new System.Windows.Forms.Padding(4);
            this.panelOpcionesListaVideos.Name = "panelOpcionesListaVideos";
            this.panelOpcionesListaVideos.Size = new System.Drawing.Size(400, 37);
            this.panelOpcionesListaVideos.TabIndex = 3;
            this.panelOpcionesListaVideos.MouseLeave += new System.EventHandler(this.panelOpcionesListaVideos_MouseLeave);
            // 
            // btnAñadorVideos
            // 
            this.btnAñadorVideos.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadorVideos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadorVideos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAñadorVideos.Enabled = false;
            this.btnAñadorVideos.FlatAppearance.BorderSize = 0;
            this.btnAñadorVideos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAñadorVideos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnAñadorVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadorVideos.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAñadorVideos.IconColor = System.Drawing.Color.Cornsilk;
            this.btnAñadorVideos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadorVideos.IconSize = 25;
            this.btnAñadorVideos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAñadorVideos.Location = new System.Drawing.Point(40, 0);
            this.btnAñadorVideos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadorVideos.Name = "btnAñadorVideos";
            this.btnAñadorVideos.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnAñadorVideos.Size = new System.Drawing.Size(40, 37);
            this.btnAñadorVideos.TabIndex = 0;
            this.btnAñadorVideos.UseVisualStyleBackColor = false;
            this.btnAñadorVideos.Click += new System.EventHandler(this.btnAñadorVideos_Click);
            this.btnAñadorVideos.MouseLeave += new System.EventHandler(this.btnAñadorVideos_MouseLeave);
            // 
            // btnNuevaListaVideos
            // 
            this.btnNuevaListaVideos.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaListaVideos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaListaVideos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNuevaListaVideos.FlatAppearance.BorderSize = 0;
            this.btnNuevaListaVideos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNuevaListaVideos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNuevaListaVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaListaVideos.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnNuevaListaVideos.IconColor = System.Drawing.Color.Cornsilk;
            this.btnNuevaListaVideos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaListaVideos.IconSize = 25;
            this.btnNuevaListaVideos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaListaVideos.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaListaVideos.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaListaVideos.Name = "btnNuevaListaVideos";
            this.btnNuevaListaVideos.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnNuevaListaVideos.Size = new System.Drawing.Size(40, 37);
            this.btnNuevaListaVideos.TabIndex = 0;
            this.btnNuevaListaVideos.UseVisualStyleBackColor = false;
            this.btnNuevaListaVideos.Click += new System.EventHandler(this.btnNuevaListaVideos_Click);
            this.btnNuevaListaVideos.MouseLeave += new System.EventHandler(this.btnNuevaListaVideos_MouseLeave);
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 459);
            this.Controls.Add(this.panelListaVideos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.wmpPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(912, 459);
            this.Name = "frmVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmVideo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVideo_MouseMove);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPantalla)).EndInit();
            this.panelListaVideos.ResumeLayout(false);
            this.panelListaReproduccion.ResumeLayout(false);
            this.panelListaReproduccion.PerformLayout();
            this.panelOpcionesListaVideos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private FontAwesome.Sharp.IconButton btnIniciarReanudar;
        private FontAwesome.Sharp.IconButton btnVolumen;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnSilenciar;
        private XComponent.SliderBar.MACTrackBar tbProgreso;
        private XComponent.SliderBar.MACTrackBar tbVolumen;
        private FontAwesome.Sharp.IconButton btnPausar;
        private AxWMPLib.AxWindowsMediaPlayer wmpPantalla;
        private FontAwesome.Sharp.IconButton btnParar;
        private System.Windows.Forms.Timer TiempoReproduccion;
        private FontAwesome.Sharp.IconButton btnLista;
        private System.Windows.Forms.ListBox lbListadoVideos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelListaVideos;
        private FontAwesome.Sharp.IconButton btnNuevaListaVideos;
        private FontAwesome.Sharp.IconButton btnAñadorVideos;
        private System.Windows.Forms.Panel panelOpcionesListaVideos;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblTranscurrido;
        private System.Windows.Forms.Panel panelListaReproduccion;
        private System.Windows.Forms.Label lblListaReproduccion;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Button btnBusca;
    }
}

