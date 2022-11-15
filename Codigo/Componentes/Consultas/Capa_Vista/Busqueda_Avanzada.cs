using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Capa_VistaConsultas
{
    // Josue Amaya 0901-19-12421
    //busqueda Avanzada 
    public partial class Busqueda_Avanzada : Form
    {
        //Conexion cn = new Conexion();
        OdbcConnection cn = new OdbcConnection(" Dsn=Colchoneria");

        String tableN;
        String datobuscar = "";
        String buscaren = "";
        String cadenaB = "";

        public Busqueda_Avanzada()
        {
            InitializeComponent();
            btn_BuscarBA.Enabled = true;
                CargarTablas();

        }
        public void CargarTablas()
        {
            cn.Open();
            cbo_buscaren.DataSource = cn.GetSchema("Tables");
            cbo_buscaren.DisplayMember = "TABLE_NAME";
            cn.Close();

        }

        private void btn_SalirBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_nuevaBA_Click(object sender, EventArgs e)
        {
            panelResultado.Visible = false;
            btn_BuscarBA.Enabled = true;
            cbox_columnas.Items.Clear();
            lbl_cadena.Text = "";
            btn_BuscarBA.Enabled = true;
        }

        private void btn_BuscarBA_Click(object sender, EventArgs e)
        {
            tableN = cbo_buscaren.Text;
            DataTable dt = new DataTable();
            try
            {
                string cadena = " SELECT  * FROM " + tableN;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn);
                datos.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    panelResultado.Visible = true;
                    dgvDato.DataSource = dt;
                }
            }
            catch
            {
                String textalert = " Error al consultar Tabla ";
                MessageBox.Show(textalert);
            }
        }

        private void pnl_BuscarBA_Paint(object sender, PaintEventArgs e)
        {
            btn_BuscarBA.Enabled = true;
            CargarColumnas(cbox_columnas, tableN);
        }

        private void bnt_buscaPor_Click(object sender, EventArgs e)
        {
            datobuscar = txt_BuscaPor.Text;
            buscaren = cbox_columnas.Text;

            BuscaPor(datobuscar, buscaren, tableN);
            CargarColumnas(cbox_columnas, tableN);
            cadenaB = "";
        }

        public void CargarColumnas(ComboBox cbox_columnas, String tableN)
        {
            cbox_columnas.Items.Clear();
            int ndgv = dgvDato.Columns.Count;

            for (int i = 0; i < ndgv; i++)
            {
                String nameC;
                nameC = dgvDato.Columns[i].HeaderText;
                int ncbx = cbox_columnas.Items.Count;
                if (ncbx < ndgv)
                {
                    cbox_columnas.Items.Add(nameC);
                }
            }
        }

        private void BuscaPor(string datobuscar, string buscaren, string tableN)
        {

            if (string.IsNullOrEmpty(datobuscar))
            {
                String textalert = " El campo buscar, se encuentra vacio ";
                MessageBox.Show(textalert);
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    cadenaB = "";
                    cn.Open();
                    cadenaB = " SELECT * FROM " + tableN + " WHERE " + buscaren + " LIKE ('%" + datobuscar.Trim() + "%')";
                    lbl_cadena.Text = "Buscando : " + datobuscar + " En Columna : " + buscaren;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, cn);
                    datos.Fill(dt);
                    OdbcCommand comando = new OdbcCommand(cadenaB, cn);
                    OdbcDataReader leer;
                    leer = comando.ExecuteReader();


                    if (dt.Rows.Count > 0)
                    {
                        panelResultado.Visible = true;
                        dgvDato.DataSource = dt;
                        cadenaB = "";
                        datobuscar = "";
                        buscaren = "";
                        txt_BuscaPor.Text = "";
                    }
                }
                catch
                {
                    String textalert = " El dato : " + datobuscar + " No se encuentra en la Columna : " + buscaren;
                    MessageBox.Show(textalert);

                    cn.Close();
                }
            }
            cadenaB = "";
            datobuscar = "";
            buscaren = "";
            txt_BuscaPor.Text = "";
        }

        private void btn_HelpmeBS_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../../../Ayuda/Componentes/Consultas/Ayuda_Busqueda_Avanzada/BsimpleHelp.chm", "Bavanzada.html");
        }

        private void Busqueda_Avanzada_Load(object sender, EventArgs e)
        {

        }

        private void panelResultado_Paint(object sender, PaintEventArgs e)
        {
            btn_BuscarBA.Enabled = false;
        }
    }
}
