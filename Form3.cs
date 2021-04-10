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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int xClick = 0, yClick = 0;
        string[] Vector = new string[4];//Credación de Vector

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool ExisteArchivo()//Funcion BOOL para Verificar Si el Archivo xml Existe
        {
            try
            {
                //dataSet1.ReadXml(Application.StartupPath + "\\ArchivoUsuarios.xml");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool VerificarCamposLlenos(TextBox aux)
        {
            if (aux.Text == "")
            {
                MessageBox.Show("*Campo Obligatorio");
             
                return false;
            }
            else
            {
               return VerificarSoloLetras(aux);
            }
        }

        private bool VerificarCamposLlenos2(TextBox aux)
        {
            if (aux.Text == "")
            {
                MessageBox.Show("*Campo Obligatorio");
                
                return false;
            }
            else
            {
                return true;
            }
           
            
        }


        private bool VerificarSoloLetras(TextBox aux)
        {
            int r, a;
            string Auxiliar = aux.Text;
            char[] num = Auxiliar.ToArray();
            r = 0;
            a = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if ((num[i] >= 65 && num[i] <= 90) || (num[i] >= 97 && num[i] <= 122) || num[i] == 127 || num[i] == 239)
                {
                    r++;
                }
                else
                {
                    a++;
                }
            }

            if (a > 0)
            {
                
                MessageBox.Show("*Ingrese solo letras");
                return false;
            }
            else
            {

                return true;
            }
        }

        private bool VerificarCedula(TextBox aux)//Funcion Para Verificar Cédula
        {
            int lim = 10;
            int res;
            string Cedula = aux.Text;
            char[] num = Cedula.ToArray();

            if (num.Length == 10)//Verifica que la Cédula Ingresada Tenga 10 Dígitos
            {
                ClCedula objVerificar = new ClCedula(num, lim);//Instanciación de Clase Cedula
                res = objVerificar.Verificar();//LLamado a Funcion para Verificar La Cédula
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    //Si la Cédula Ingresada Es Incorrecta
                    MessageBox.Show("Cédula Incorrecta");
                  
                    aux.Text = "";
                    return false;
                }
            }
            else
            {
                //Si La Cédula Ingresada No Contiene 10 Dígitos
                MessageBox.Show("*La Cédula No Contiene 10 Dígitos");
               
                //aux.Text = "";
                return false;
            }

        }


        private bool VerificarCI(TextBox aux)
        {
            if (aux.Text == "")
            {
                MessageBox.Show("*Campo Obligatorio  -  Ingreso de la CI");
                textBox3.Text = "";
                textBox3.Focus();
                return false;
            }
            else
            {
                return VerificarCedula(aux);


            }

        }

        //private bool VerificarCampos()//Funcion para Verificar que los Campos en el Form Sean Correctos
        //{
        //    bool correctoN, correctoA, correctoAs, correctoCI;
        //    correctoN = VerificarCamposLlenos(textBox1);
        //    correctoA = VerificarCamposLlenos(textBox2);
        //    correctoCI = VerificarCI(textBox3);
        //    correctoAs = VerificarCamposLlenos2(textBox4);


        //    if ((correctoCI == true) && (correctoN == true) && (correctoA == true) && (correctoAs == true))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;

        //    }
        //}


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("DESEA CONTINUAR CON EL REGISTRO DE NUEVO USUARIO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //do something

            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();

            }
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private bool CedulaCorrecta()
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("*Campo Obligatorio -- Ingreso de la CI ");
                return false;
            }
            else
            {
                return VerificarCedula(textBox3);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox4.Focused == true)
                textBox4.BackColor = Color.White;
        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            //Message Box para Asegurar que Se Desea Guardar la Informacion Introducida
            DialogResult opcion = MessageBox.Show("¿ESTÁ SEGURO QUE DESEA CREAR EL USUARIO?", "Verificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (opcion == DialogResult.OK)//Si se Acepta Continuar Con el Guardado
            {
                bool correctoN, correctoA, correctoAs, correctoCI;
                correctoN = VerificarCamposLlenos(textBox1);
                correctoA = VerificarCamposLlenos(textBox2);
                correctoCI = VerificarCI(textBox3);
                correctoAs = VerificarCamposLlenos2(textBox4);
                if (correctoN == true)//Si los Campos Son Correctos
                {
                    if (correctoA == true)
                    {
                        if (correctoCI == true)
                        {
                            if (correctoAs == true)
                            {
                                pbRegistrar.Visible = true;
                            }
                            else
                            {
                                textBox4.Text = "";
                                textBox4.Focus();
                                gunaWinSwitch1.Checked = false;
                            }
                        }
                        else
                        {
                            textBox3.Text = "";
                            textBox3.Focus();
                            gunaWinSwitch1.Checked = false;

                        }

                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox2.Focus();
                        gunaWinSwitch1.Checked = false;
                    }
                }
                else
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    gunaWinSwitch1.Checked = false;
                }
                
            }
            else
            {
                MessageBox.Show("DEBE ACEPTAR LOS TERMINOS PARA CONTINUAR","VALIDACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            /*textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;*/

            textBox2.BackColor = Color.DarkGray;
            textBox3.BackColor = Color.DarkGray;
            textBox4.BackColor = Color.DarkGray;

           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //textBox2.Enabled=true;
                
                textBox2.Focus();
                textBox2.BackColor = Color.White;
                if (textBox2.Focused==true)
                    textBox2.BackColor = Color.White;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Focused == true)
                textBox2.BackColor = Color.White;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //textBox3.Enabled = true;
                textBox3.BackColor = Color.White;
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.Focused == true)
                textBox3.BackColor = Color.White;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //textBox4.Enabled = true; 
                textBox4.BackColor = Color.White;
                gunaWinSwitch1.Checked = false;
                textBox4.Focus();
            }
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void pbRegistrar_Click(object sender, EventArgs e)
        {
            
            //Message Box para Asegurar que Se Desea Guardar la Informacion Introducida
            DialogResult opcion = MessageBox.Show("¿LA INFORMACIÓN PROPORCIONADA ES CORRECTA?", "Verificación", MessageBoxButtons.OKCancel);
            if (opcion == DialogResult.OK)//Si se Acepta Continuar Con el Guardado
            {
                //dataSet1.Clear();
                /*if (ExisteArchivo() == true)//SI Existe el Archivo xml
                {
                    dataSet1.Clear();
                    dataSet1.ReadXml(Application.StartupPath + "\\ArchivoUsuarios.xml");//Lectura de Arcnivo xml
                }*/

                //Ingreso de Campos
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string ci = textBox3.Text;
                string cntr = textBox4.Text;
                //

                string[] Vector = new string[4];//Credación de Vector

                //Guardado de Campos en Vector
                Vector[0] = nombre;
                Vector[1] = apellido;
                Vector[2] = ci;
                Vector[3] = cntr;
                //
                try
                {
                    //dataSet1.DataTable1.Rows.Add(Vector);//Agregar Vector 
                    //dataSet1.WriteXml(Application.StartupPath + "\\ArchivoUsuarios.xml");//Escritura en Archivo xml
                    MessageBox.Show("NUEVO USUARIO REGISTRADO", "REGISTRO COMPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 frmIniciar = new Form2(Vector);
                    frmIniciar.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("La Cedula Ya Se Encuentra Registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = "";
                    gunaWinSwitch1.Checked = false;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("DESEA CONTINUAR CON EL REGISTRO DE NUEVO USUARIO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //do something

            }
            else if (dialogResult == DialogResult.No)
            {
                Form2 frmIniciar = new Form2(Vector);
                frmIniciar.Show();
                this.Close();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            {
                this.Left = this.Left + (e.X - xClick);

                this.Top = this.Top + (e.Y - yClick);
            }
        }
    }
}
