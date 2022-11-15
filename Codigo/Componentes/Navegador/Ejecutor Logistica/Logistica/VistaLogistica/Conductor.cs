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
    public partial class Conductor : Form
    {
        public Conductor()
        {
            InitializeComponent();
        }

        private void Conductor_Load(object sender, EventArgs e)
        {
            this.txtact.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
