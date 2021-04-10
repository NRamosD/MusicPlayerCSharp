using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;




namespace WFReproductorMusica
{
    public partial class Form1 : Form
    {
        ReproductorVideo.frmVideo formVideo = new ReproductorVideo.frmVideo();
        WinAppMyMusic.Form1 frmMusic = new WinAppMyMusic.Form1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbMusic.Checked = true;

            
        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVideo.Checked)
            {
                rbVideo.ForeColor = Color.Black;
                if (this.contentPanel.Controls.Count > 0)
                    this.contentPanel.Controls.RemoveAt(0);


                formVideo.TopLevel = false;
                formVideo.FormBorderStyle = FormBorderStyle.None;
                formVideo.Dock = DockStyle.Fill;
                this.contentPanel.Controls.Add(formVideo);
                this.contentPanel.Tag = formVideo;
                formVideo.Show();
            }
            else
            {
                rbVideo.ForeColor = Color.White;
                
            }
        }

        private void rbConfig_CheckedChanged(object sender, EventArgs e)
        {
        }

       

        private void rbMusic_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbMusic.Checked)
            {
                rbMusic.ForeColor = Color.Black;
                if (this.contentPanel.Controls.Count > 0)
                    this.contentPanel.Controls.RemoveAt(0);
                frmMusic.TopLevel = false;
                frmMusic.FormBorderStyle = FormBorderStyle.None;
                frmMusic.Dock = DockStyle.Fill;
                this.contentPanel.Controls.Add(frmMusic);
                this.contentPanel.Tag = frmMusic;
                frmMusic.Show();
            }
            else
            {
                rbMusic.ForeColor = Color.White;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath+"//Ayuda.htm");
        }
    }
}
