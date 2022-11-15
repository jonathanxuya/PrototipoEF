using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaLogistica
{
    public partial class Bodega : Form
    {
        public Bodega()
        {
            InitializeComponent();
        }
        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtact.Text = "1";
            }
            else
            {
                txtact.Text = "0";
            }
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            this.txtact.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
