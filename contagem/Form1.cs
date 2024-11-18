using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbResultado1.Items.Clear();
            lsbResultado2.Items.Clear();
        }

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            lsbResultado1.Items.Clear();

            int i = 1;
            while( i <= 100)
            {
                lsbResultado1.Items.Add(i);
                i++;
            }
        }

        private void btnCalcular10_Click(object sender, EventArgs e)
        {
            lsbResultado2.Items.Clear();


            int i = 0;
            while ( i <= 1000)
            {
                lsbResultado2.Items.Add(i);
                i+=10;
            }

        }
    }
}
