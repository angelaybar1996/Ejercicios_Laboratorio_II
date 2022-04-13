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
    public partial class FrmSaludo : Form
    {
        public FrmSaludo(string titulo,string mensaje)
        {
            
            InitializeComponent();
            lbl_Titulo.Text = titulo;
            lbl_Mensaje.Text = mensaje;


        }
    }
}
