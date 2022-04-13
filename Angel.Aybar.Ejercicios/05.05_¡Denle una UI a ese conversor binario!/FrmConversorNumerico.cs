using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _04._03_Entidades;

namespace _05._05__Denle_una_UI_a_ese_conversor_binario_
{
    public partial class FrmConversorNumerico : Form
    {
        public FrmConversorNumerico()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            //en el casteo esta el constructor privado
            NumeroBinario numBin = (NumeroBinario)txtBinario.Text;
            double num;

            num = numBin.ConvertirBinarioADecimal(numBin.Numero);

            txtResultadoDec.Text = num.ToString();

        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            //en el casteo esta el constructor privado
            NumeroDecimal numDec = (NumeroDecimal)Convert.ToDouble((txtDecimal.Text));
            string num;

            num = numDec.ConvertirDecimalABinario(numDec.Numero);

            txtResultadoBin.Text = num;
        }
    }
}
