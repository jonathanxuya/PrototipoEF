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
    public partial class Envio : Form
    {
        public Envio()
        {
            InitializeComponent();
        }

        private void Envio_Load(object sender, EventArgs e)
        {
            this.txtIdAplicacion.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
