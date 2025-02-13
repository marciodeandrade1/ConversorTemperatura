using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            //declaração das variáveis
            int Tcel, TKel, TFah;

            //lendo a temperatura a ser convertida
            Tcel = int.Parse(txtCelcius.Text);

            //calculando as conversões
            TKel = Tcel + 273;
            TFah = (((Tcel * 9) / 5) + 32);

            lblTk.Text = TKel.ToString();
            lblTf.Text = TFah.ToString();
        }
    }
}
