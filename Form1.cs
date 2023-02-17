using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers
{
    public partial class Form1 : Form
    {
        // Variable que acumula el total del pedido
        double Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Condiciones para la marca del equipo 
            if (this.rdbAsus.Checked)
                Total += 1000000;
            if (this.rdbLenovo.Checked)
                Total += 1200000;
            if (this.rdbDell.Checked)
                Total += 1300000;
            if (this.rdbMac.Checked)
                Total += 3000000;
            if (this.rdbToshiba.Checked)
                Total += 900000;
            if (this.rdbGoogle.Checked)
                Total += 2200000;
            if (this.rdbHp.Checked)
                Total += 1200000;
            if (this.rdbAcer.Checked)
                Total += 1500000;
            if (this.rdbXiaomi.Checked)
                Total += 1700000;

            //Condiciones para la capacidad del equipo encuento a lamacenamiento 
            if (this.rdb100.Checked)
                Total += 200000;
            if (this.rdb256.Checked)
                Total += 300000;
            if (this.rdb1T.Checked)
                Total += 600000;
            if (this.rdb150.Checked)
                Total += 150000;
            if (this.rdb500.Checked)
                Total += 700000;
            if (this.rdb2T.Checked)
                Total += 1000000;
            if (this.rdb250.Checked)
                Total += 850000;
            if (this.rdb550.Checked)
                Total += 875000;
            if (this.rdb3T.Checked)
                Total += 1800000;

            //Condiciones para la capacidad de RAM
            if (this.rdb2.Checked)
                Total += 100000;
            if (this.rdb8.Checked)
                Total += 200000;
            if (this.rdb12.Checked)
                Total += 400000;
            if (this.rdb4.Checked)
                Total += 300000;
            if (this.rdb6.Checked)
                Total += 600000;
            if (this.rdb16.Checked)
                Total += 1000000;

            //Condiciones para tipo dde disco duro 
            if (this.cmbTipoDisco.SelectedIndex == 0)
                Total += Total*0.2;
            if (this.cmbTipoDisco.SelectedIndex == 1)
                Total += Total*0.5;
            if (this.cmbTipoDisco.SelectedIndex == 2)
                Total += Total*0.9;

            //Condicioned para los accesorios 

            if (this.cheAURICULARES.Checked)
                Total += 50000;
            if (this.cheMouse.Checked)
                Total += 50000;
            if (this.cheParlantes.Checked)
                Total += 100000;
            if (this.cheWebCam.Checked)
                Total += 400000;
            if (this.cheAURICULARES.Checked)
                Total += 50000;
            if (this.cheRefrigerador.Checked)
                Total += 500000;
            if (this.cheSoporte.Checked)
                Total += 20000;
            if (this.cheTeclado.Checked)
                Total += 80000;
            if (this.cheDiscoExterno.Checked)
                Total += 1000000;

            //Se lleva el valor de acomulado en la variable Total al textBox
            txtTotal.Text = string.Format(new CultureInfo("es-CO"), "{0:C2}", Total);


            //Al inicializar la variable en 0 me permite que si alguno de los objetos cambia 
            //Y se buelve a dar calcular solo se actualice los valores que cambiaron, de esa manera evitamos que se dupliquen
            //Los valor que ya fueros sumados en la acción anterior de calcular.
            Total = 0;

        }
    }
}
