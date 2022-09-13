using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double importe, total, valorDescuento;
            double descuento = 0;

            if(textBox1.Text != "")
            {
                importe = Convert.ToInt32(textBox1.Text);

                if (importe >= 3000 && importe <= 5000)
                {
                    descuento = 0.10;
                }
                else if (importe >= 5000)
                {
                    descuento = 0.20;
                }
                else
                {
                    total = importe;
                }
                valorDescuento = importe * descuento;
                total = importe - valorDescuento;
                this.textBox2.Text = Convert.ToString(valorDescuento);
                this.textBox3.Text = Convert.ToString(total);
            }
        }
    }
}
