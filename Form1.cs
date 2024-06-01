using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmImc : Form
    {
        public frmImc()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Decimal Altura = Convert.ToDecimal(txtAltura.Text);
            Decimal Peso = Convert.ToDecimal(txtPeso.Text);

            Decimal Resultado = 0;
            Resultado = Peso / (Altura * Altura);

            if(Resultado <= 19 )
            {
                pctImagen.Image = Properties.Resources.Bajopeso;
                lblIMC.Text = "El paciente se encuentra con bajo peso. Se recomienda un cambio de alimentación.";
            } else if (Resultado < 25 )
            {
                pctImagen.Image = Properties.Resources.Normal;
                lblIMC.Text = "El paciente se encuentra con peso normal.";
            } else if(Resultado > 25 && Resultado < 30)
            {
                pctImagen.Image = Properties.Resources.Sobrepeso;
                lblIMC.Text = "El paciente presenta sobrepeso. Se recomienda un cambio de alimentación.";
            } else if (Resultado > 30)
            {
                pctImagen.Image = Properties.Resources.Obeso;
                lblIMC.Text = "El paciente se encuentra obeso. Se recomienda un cambio de alimentación y ejercicio.";
            }


}

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
