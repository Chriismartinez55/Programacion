using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplos_del_libto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prb1.Minimum = 1;
            prb1.Maximum= 100;
            prb1.Step = 2;

            for (int x=0; x<100; x++)
            {
                prb1.PerformStep();
            }

        
        }
    }
}
