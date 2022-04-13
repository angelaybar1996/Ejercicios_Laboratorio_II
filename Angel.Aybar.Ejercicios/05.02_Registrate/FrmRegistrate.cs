using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _05._02_Entidades;


namespace _05._02_Registrate
{
    public partial class FrmRegistrate : Form
    {
        

        public FrmRegistrate()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
         
            string genero;
            string[] cursos;
           
            genero = string.Empty;
            cursos = new string[3]  { "C#", "C++","JavaScript" };//le establesco el tamaño        

            //establece el o los cursos
            if (chb_Csharp.Checked == true)
            {
                for (int i = 0; i < cursos.Length; i++)
                {
                    cursos[0]=cursos[0];
                    cursos[1] = string.Empty;
                    cursos[2] = string.Empty;
                    

                }
            }
            else if (chb_Cmasmas.Checked == true)
            {
                
                    cursos[0] = cursos[1];
                    cursos[1] = string.Empty;
                    cursos[2] = string.Empty;

            }
            else if (chb_Javascript.Checked==true)
            {
                
                    cursos[0] = cursos[2];
                    cursos[1] = string.Empty;
                    cursos[2] = string.Empty;

            }
            else if (chb_Csharp.Checked == true && chb_Cmasmas.Checked == true && chb_Javascript.Checked == true)
            {
                for (int i = 0; i < cursos.Length; i++)
                {
                    cursos[i] = cursos[i];
                }
            }
            else if(chb_Csharp.Checked == false && chb_Cmasmas.Checked == false && chb_Javascript.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //establece el genero
            if (rb_Masculino.Checked==true)
            {
                genero = "Masculino";
            }
            else if(rb_Femenino.Checked == true)
            {
                genero = "Femenino";
            }
            else if(rd_No_Binario.Checked==true)
            {
                genero = "No binario";
            }
            else if(rb_Masculino.Checked == false && rb_Femenino.Checked == false && rd_No_Binario.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            Ingresante ingreso = new Ingresante(cursos,
                tb_Direccion.Text,((byte)nud_Edad.Value),genero,tb_Nombre.Text, lsb_Pais.SelectedItem.ToString());

            MessageBox.Show(ingreso.Mostrar(), "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
