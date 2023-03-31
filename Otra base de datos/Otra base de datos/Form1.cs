using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otra_base_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarDB_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"c:\temp\myData.db"))
            {
                var col = db.GetCollection

            }
    }
}
