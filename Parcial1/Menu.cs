using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Num1;
            int Num2;
            int Res;
            Num1 = Convert.ToInt32(Numero1.Text);
            Num2 = Convert.ToInt32(Numero2.Text);
            if (Num1 > Num2)
            {
                Res = Num1;
                Resultado.Text = Res.ToString();
            }
            else
            {
                Res = Num2;
                Resultado.Text = Res.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Numero1.Text = "";
            Numero2.Text = "";
            Resultado.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
