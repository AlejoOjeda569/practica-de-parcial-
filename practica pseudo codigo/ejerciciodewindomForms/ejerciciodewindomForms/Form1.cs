using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciodewindomForms
{
    public partial class escritorio : Form
    {
        public escritorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            inicializarcontroles();
        }

        private void inicializarcontroles()
        {
            txtAltura.Clear();
            txtRadio.Clear();
            txtGeneratriz.Clear();
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            var Altura = double.Parse(txtAltura.Text);
            var Radio = double.Parse(txtRadio.Text);
            var Generatriz = double.Parse(txtGeneratriz.Text);
            double pi = 3.14159265;
           
            double Volumen = ValordeVolumen(Altura, Radio, pi);
            MessageBox.Show($"El volumen es= {Volumen} ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
           private void btnArea_Click(object sender, EventArgs e)
        {
            var Altura = double.Parse(txtAltura.Text);
            var Radio = double.Parse(txtRadio.Text);
            var Generatriz = double.Parse(txtGeneratriz.Text);
            double pi = 3.14159265;
            double Area = Valordelarea(Generatriz, Radio, pi);
            MessageBox.Show($"El area es= {Area} ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        private double ValordeVolumen(double altura, double radio, double pi) => (pi * Math.Pow(radio, 2) * altura) / 3;
       
        private double Valordelarea(double generatriz, double radio, double pi) => pi * radio * (radio + generatriz);

        private void escritorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro de querer Salir ?","Pregunta",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2 );
            if (dr==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fin del Programa","Salir",
                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Application.Exit();
           
        }
    }
}
