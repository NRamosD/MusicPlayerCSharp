using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.TrabajoGrupal
{
    public partial class Form2 : Form
    {
        //INICIO
        WFReproductorMusica.Form1 frmInicio = new WFReproductorMusica.Form1();

        string [] User = new string[4];
        public Form2(string [] usuario)
        {
            InitializeComponent();
            User = usuario;
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int xClick = 0, yClick = 0;

        private void bunifuImageButton2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            {
                this.Left = this.Left + (e.X - xClick);

                this.Top = this.Top + (e.Y - yClick);
            }
        }

        private void gunaGradient2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            {
                this.Left = this.Left + (e.X - xClick);

                this.Top = this.Top + (e.Y - yClick);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Close();
            Form3 objregistrarse = new Form3();
            objregistrarse.Show();
            //objregistrarse.FormClosed += 
            this.Hide();
        }

        private void bunifuImageButton1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            {
                this.Left = this.Left + (e.X - xClick);

                this.Top = this.Top + (e.Y - yClick);
            }
        }


        

        private void Form2_Load(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.HintText = "Ingrese su cédula";
            bunifuMaterialTextbox2.HintText = "Ingrese su contraseña";
        }


        string cntr;  //Variable para verificar contraseña
        string ci;

       

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Verificar que los TextBox esten llenos
                if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "")
                {
                    MessageBox.Show("*Campo Obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    //if (VerificarUsuario() == true)//Si el Usuario Ingresado es Correcto
                    //{
                    if (User[2] == bunifuMaterialTextbox1.Text && User[3] == bunifuMaterialTextbox2.Text)//Verificar que la Contraseña sea Correcta
                    {
                        // FrmPrincipalMusica objMenuMusic = new FrmPrincipalMusica();
                        // objMenuMusic.cntr = cntr;
                        // objMenuMusic.ci = ci;
                        MessageBox.Show("Bienbenido a My Music", "Genial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Visible = false;

                        frmInicio.Show();
                    }
                    else//Si la Contraseña Ingresada Es Incorrecta
                    {
                        MessageBox.Show("La Contraseña Ingresada Es Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //}
                }

            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "")
            {
                MessageBox.Show("*Campo Obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                //if (VerificarUsuario() == true)//Si el Usuario Ingresado es Correcto
                //{
                    if (User[2] == bunifuMaterialTextbox1.Text && User[3] == bunifuMaterialTextbox2.Text)//Verificar que la Contraseña sea Correcta
                    {
                        // FrmPrincipalMusica objMenuMusic = new FrmPrincipalMusica();
                        // objMenuMusic.cntr = cntr;
                        // objMenuMusic.ci = ci;
                        MessageBox.Show("Bienvenido a My Music", "Genial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Visible = false;
                        
                        frmInicio.Show();
                    }
                    else//Si la Contraseña Ingresada Es Incorrecta
                    {
                        MessageBox.Show("La Contraseña Ingresada Es Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                //}
            }
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            
        }

        /*private bool VerificarUsuario()//FUncion para Verficar el Usuario en la Cuenta Docente
        {
            bool bandera = true;
            int lim = 10;
            int res;
            string Cedula = bunifuMaterialTextbox1.Text;
            char[] num = Cedula.ToArray();

            if (num.Length == 10)// Verifica que la Cédula Ingresada Tenga 10 Dígitos
            {
                ClCedula objVerificar = new ClCedula(num, lim);//Instancia de la Clase Cédula
                res = objVerificar.Verificar();//Controlar que la Cedula Ingresada sea Correcta
                if (res > 0)//SI LA CÉDULA ES CORRECTA//
                {
                    dataSet11.Clear();
                    dataSet11.ReadXml(Application.StartupPath + "\\ArchivoUsuarios.xml");//Lectura de Archivo xml
                    DataRow[] Vector;
                    Vector = dataSet11.DataTable1.Select("CI='" + bunifuMaterialTextbox1.Text + "'");//Busqueda de CI
                    if (Vector.Length > 0)//Si se Encuentra al Usuario en el Archivo xml
                    {
                        bandera = true;
                        cntr = Vector[0]["Cntr"].ToString();//Asignación de Contraseña Guardada en Archivo a Variable
                        ci = Vector[0]["CI"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("*El Usuario No Existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);//Si No se Encuentra el Usuario en el archivo
                    }
                }
                else
                {
                    MessageBox.Show("Cédula Incorrecta");//Si la Cédula Ingresada es Incorrecta
                    bunifuMaterialTextbox2.Text = "";
                    bandera = false;
                }
            }
            else
            {
                MessageBox.Show("La Cédula No Contiene 10 dígitos, INCORRECTO");//Si la cédula Ingresada no tiene 10 dígitos
                bunifuMaterialTextbox1.Text = "";
                bandera = false;
            }
            return bandera;
        }*/








    }
}
