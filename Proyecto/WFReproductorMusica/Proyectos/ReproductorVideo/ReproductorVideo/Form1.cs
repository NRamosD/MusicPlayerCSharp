using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorVideo
{
    public partial class frmVideo : Form
    {
        int volumen, indice;
        bool iniciarReanudarPausar = false, boolListaVideos = false, silenciar=true;
        List<clVideos> ListaVideos = new List<clVideos>();
        TagLib.File metadatosVideo;



        #region Controles

        public void ControlPosicionBotones()
        {

            btnIniciarReanudar.Left = (this.ClientSize.Width - btnIniciarReanudar.Width) / 2;
            btnPausar.Left = (this.ClientSize.Width - btnPausar.Width) / 2;
            btnAnterior.Location = new Point(btnIniciarReanudar.Location.X - 112, btnIniciarReanudar.Location.Y);
            btnParar.Location = new Point(btnIniciarReanudar.Location.X - 56, btnIniciarReanudar.Location.Y);
            btnSiguiente.Location = new Point(btnIniciarReanudar.Location.X + 56, btnIniciarReanudar.Location.Y);
            btnLista.Location = new Point(btnIniciarReanudar.Location.X + 112, btnIniciarReanudar.Location.Y);
        }

        private void IniciarReanudarPausar()
        {
            switch (iniciarReanudarPausar)
            {
                case true:
                    wmpPantalla.Ctlcontrols.play();
                    iniciarReanudarPausar = false;
                    btnIniciarReanudar.Visible = false;
                    btnPausar.Visible = true;
                    break;

                case false:
                    wmpPantalla.Ctlcontrols.pause();
                    iniciarReanudarPausar = true;
                    btnIniciarReanudar.Visible = true;
                    btnPausar.Visible = false;
                    break;
            }
        }

        private void Silenciar()
        {
            switch (silenciar)
            {
                case true:
                    btnVolumen.Visible = false;
                    btnSilenciar.Visible = true;
                    volumen = tbVolumen.Value;
                    tbVolumen.Value = 0;
                    silenciar = false;
                    break;

                case false:
                    btnVolumen.Visible = true;
                    btnSilenciar.Visible = false;
                    tbVolumen.Value = volumen;
                    wmpPantalla.settings.volume = volumen;
                    silenciar = true;

                    break;
            }
        }

        private void PanelListaVideos()
        {
             if (MousePosition.X < this.ClientSize.Width-300 || MousePosition.Y > panelListaVideos.Height)
            {
                panelListaVideos.Visible = false;
                boolListaVideos = false;
            }
        }

        private void ControlBotonAñadorVideos()
        {
            if (lbListadoVideos.Items.Count == 0)
            {
                btnAñadorVideos.Enabled = false;
            }
            else
            {
                btnAñadorVideos.Enabled = true;
            }
        }

        #endregion

        #region Tiempo

        private void ActualizarTiempoReproduccion()
        {
            if (wmpPantalla.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                tbProgreso.Maximum = (int)wmpPantalla.Ctlcontrols.currentItem.duration;
                TiempoReproduccion.Start();
            }
            else if (wmpPantalla.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                TiempoReproduccion.Stop();
            }
            else if (wmpPantalla.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                TiempoReproduccion.Stop();
                tbProgreso.Value = 0;
            }
        }

        #endregion

        public frmVideo()
        {
            InitializeComponent();
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            wmpPantalla.uiMode = "none";
            btnBusca.Enabled = false;
            ControlPosicionBotones();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //btnMinimizar.Visible = true;
            //btnMaximizar.Visible = false;
            //this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //btnMaximizar.Visible = true;
            //btnMinimizar.Visible = false;
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void btnIniciarReanudar_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                IniciarReanudarPausar();
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                IniciarReanudarPausar();
            }
        }


        private void panelListaVideos_MouseLeave(object sender, EventArgs e)
        {
            //PanelListaVideos();
        }

        private void btnNuevaListaVideos_MouseLeave(object sender, EventArgs e)
        {
            //PanelListaVideos();
        }

        private void btnAñadorVideos_MouseLeave(object sender, EventArgs e)
        {
            //PanelListaVideos();
        }

        private void lbVideos_MouseLeave(object sender, EventArgs e)
        {
            //PanelListaVideos();
        }

        private void panelOpcionesListaVideos_MouseLeave(object sender, EventArgs e)
        {
            //PanelListaVideos();
        }

        private void frmVideo_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void TiempoReproduccion_Tick(object sender, EventArgs e)
        {
            try
            {
                ActualizarTiempoReproduccion();
                tbProgreso.Value = (int)wmpPantalla.Ctlcontrols.currentPosition;
                tbVolumen.Value = wmpPantalla.settings.volume;
                lblTranscurrido.Text = wmpPantalla.Ctlcontrols.currentPositionString;
                lblDuracion.Text = wmpPantalla.currentMedia.durationString;
            }
            catch 
            {

            }
        }

        private void btnNuevaListaVideos_Click(object sender, EventArgs e)
        {
            ControlBotonAñadorVideos();
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            objOpenFileDialog.Multiselect = true;
            objOpenFileDialog.Filter = "Seleccione videos|*.mp4";
            if (objOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ListaVideos.Clear();
                for (int i = 0; i < objOpenFileDialog.FileNames.Length; i++)
                {
                    clVideos video = new clVideos();
                    metadatosVideo = TagLib.File.Create(objOpenFileDialog.FileNames[i]);
                    if (metadatosVideo.Tag.Title == null)
                    {
                        video.Nombre = "Sin nombre";
                    }
                    else
                    {
                        video.Nombre = metadatosVideo.Tag.Title;
                    }
                    if (metadatosVideo.Tag.FirstPerformer == null)
                    {
                        video.Artista = "Sin autor";
                    }
                    else
                    {
                        video.Artista = metadatosVideo.Tag.FirstPerformer;
                    }
                    video.Direcion = objOpenFileDialog.FileNames[i];
                    video.Duracion = metadatosVideo.Properties.Duration.ToString(@"hh\:mm\:ss");
                    ListaVideos.Add(video);
                }

                lbListadoVideos.Items.Clear();
                foreach (clVideos elemento in ListaVideos)
                {
                    lbListadoVideos.Items.Add(elemento.Nombre + " - " + elemento.Artista + " - " + elemento.Duracion);
                }
                btnPausar.Visible = true;
                btnIniciarReanudar.Visible = false;
                wmpPantalla.URL = ListaVideos[0].Direcion;
                if (lbListadoVideos.Items.Count > 0)
                {
                    btnBusca.Enabled = true;
                }
                lbListadoVideos.SelectedIndex = 0;
            }
        }

        private void lbListadoVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmpPantalla.URL = ListaVideos[lbListadoVideos.SelectedIndex].Direcion;
            lblTitulo.Text = ListaVideos[lbListadoVideos.SelectedIndex].Nombre;
        }

        private void wmpPantalla_Enter(object sender, EventArgs e)
        {

        }

        private void wmpPantalla_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarTiempoReproduccion();
        }

        private void tbProgreso_ValueChanged(object sender, decimal value)
        {
            if (comprobarListBox())
            {
                tbProgreso.Maximum = (int)wmpPantalla.currentMedia.duration;
                if (tbProgreso.Value != (int)wmpPantalla.Ctlcontrols.currentPosition)
                {
                    wmpPantalla.Ctlcontrols.currentPosition = tbProgreso.Value;
                }
            }
            
        }

        private void tbVolumen_ValueChanged(object sender, decimal value)
        {
            wmpPantalla.settings.volume = tbVolumen.Value;
            lblVolumen.Text = wmpPantalla.settings.volume + "%";
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            Silenciar();
        }

        private void btnAñadorVideos_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            objOpenFileDialog.Multiselect = true;
            objOpenFileDialog.Filter = "Seleccione videos|*.mp4";
            if (objOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                indice = (objOpenFileDialog.FileNames.Length + lbListadoVideos.Items.Count);
                for (int i = lbListadoVideos.Items.Count; i < indice; i++)
                {
                    clVideos video = new clVideos();
                    metadatosVideo = TagLib.File.Create(objOpenFileDialog.FileNames[i - lbListadoVideos.Items.Count]);
                    if (metadatosVideo.Tag.Title == null)
                    {
                        video.Nombre = "Sin nombre";
                    }
                    else
                    {
                        video.Nombre = metadatosVideo.Tag.Title;
                    }
                    if (metadatosVideo.Tag.FirstPerformer == null)
                    {
                        video.Artista = "Sin autor";
                    }
                    else
                    {
                        video.Artista = metadatosVideo.Tag.FirstPerformer;
                    }
                    video.Direcion = objOpenFileDialog.FileNames[i - lbListadoVideos.Items.Count];
                    video.Duracion = metadatosVideo.Properties.Duration.ToString(@"hh\:mm\:ss");
                    ListaVideos.Add(video);
                }

                for (int i = lbListadoVideos.Items.Count; i < indice; i++)
                {
                    lbListadoVideos.Items.Add(ListaVideos[i].Nombre + " - " + ListaVideos[i].Artista + " - " + ListaVideos[i].Duracion);
                }
                btnPausar.Visible = true;
                btnIniciarReanudar.Visible = false;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                lblTranscurrido.Text = "00:00";
                wmpPantalla.Ctlcontrols.stop();
                IniciarReanudarPausar();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                if (lbListadoVideos.SelectedIndex < lbListadoVideos.Items.Count - 1)
                {
                    lbListadoVideos.SelectedIndex = lbListadoVideos.SelectedIndex + 1;
                }
                else
                {
                    lbListadoVideos.SelectedIndex = 0;
                }
                btnIniciarReanudar.Visible = false;
                btnPausar.Visible = true;
                iniciarReanudarPausar = false;
            }
            
        }

        private void wmpPantalla_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
        }

        private void lblListaReproduccion_Click(object sender, EventArgs e)
        {

        }

        private void tbBusca_Click(object sender, EventArgs e)
        {
            tbBusca.SelectAll();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                if (comprobarListBox())
                {
                    if (tbBusca.Text != "")
                    {
                        string nombre = tbBusca.Text;
                        int indexNombre = ListaVideos.FindIndex(element => element.Nombre == nombre);
                        if (indexNombre != -1)
                        {
                            wmpPantalla.URL = ListaVideos[indexNombre].Direcion;
                            lblTitulo.Text = ListaVideos[indexNombre].Nombre;
                            lbListadoVideos.SelectedIndex = indexNombre;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron coincidencias.", "Error");
                        }
                    }
                }
                
            }
            catch
            {

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                if (lbListadoVideos.SelectedIndex != 0)
                {
                    lbListadoVideos.SelectedIndex = lbListadoVideos.SelectedIndex - 1;
                }
                else
                {
                    lbListadoVideos.SelectedIndex = ListaVideos.Count - 1;
                }
                btnIniciarReanudar.Visible = false;
                btnPausar.Visible = true;
                iniciarReanudarPausar = false;
            }
            
        }

        private void btnSilenciar_Click(object sender, EventArgs e)
        {
            Silenciar();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ControlBotonAñadorVideos();
            switch (boolListaVideos)
            {
                case true:
                    panelListaVideos.Visible = false;
                    boolListaVideos = false;
                    break;

                case false:
                    panelListaVideos.Visible = true;
                    boolListaVideos = true;
                    break;
            }
        }

        public bool comprobarListBox()
        {
            if (lbListadoVideos.Items.Count > 0)
                return true;
            
            return false;
        }
    }
}
