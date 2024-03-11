using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void So1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void So2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Ketqua.Text = Convert.ToString(Convert.ToInt32(So1.Text) + Convert.ToInt32(So2.Text));
        }
    }
}
