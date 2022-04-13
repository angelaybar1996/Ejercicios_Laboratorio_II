using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._01_Hola_Windows_Forms
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargo un valor por defecto en el comboBox, notese que lo hago en el metodo Load del FrmIngreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            cmb_Materias.SelectedItem = "Estadisticas";

        }

        /// <summary>
        /// Evento que se ejecuta cuando presiono click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saludar_Click(object sender, EventArgs e)
        {
            //Condicion si el nombre y apellido estan escritos o no hacer lo correspondiente
            if(String.IsNullOrWhiteSpace(tb_Nombre.Text)==true
                && string.IsNullOrWhiteSpace(tb_Apellido.Text)==true)
            {
                MessageBox.Show("Se deben completar los siguientes campos\n Nombre\n Apellido\n",
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(tb_Nombre.Text) == true
                && string.IsNullOrWhiteSpace(tb_Apellido.Text) == false)
            {
                MessageBox.Show("Se deben completar los siguientes campos\n Nombre\n",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(tb_Nombre.Text) == false
                && string.IsNullOrWhiteSpace(tb_Apellido.Text) == true)
            {
                MessageBox.Show("Se deben completar los siguientes campos\n Apellido\n",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmSaludo saludo = new FrmSaludo($"¡Hola,Windows Form!! :)",
                $"Soy { tb_Nombre.Text } { tb_Apellido.Text } y mi materia favorita es {cmb_Materias.SelectedItem}");

                saludo.Show();
                this.Hide();
            }
                    
        }
     
    }
}
