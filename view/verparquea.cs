using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class verparquea : Form
    {
        public verparquea(string dato1, string dato2, string dato3, string dato4, string dato5)
        {
            InitializeComponent();
            dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5);
        }
        private void verparquea_Load(object sender, EventArgs e)
        {
        }

    }
}
