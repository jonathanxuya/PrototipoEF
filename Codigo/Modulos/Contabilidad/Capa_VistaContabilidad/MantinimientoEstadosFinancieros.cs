using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_VistaContabilidad
{
    
    public partial class MantinimientoEstadosFinancieros : Form
    {
        public MantinimientoEstadosFinancieros()
        {
            InitializeComponent();
        }

        public void Cargarcombo(ComboBox comboBox, string v)
        {
            Capa_VistaContabilidad.CRUD2 crud = new Capa_VistaContabilidad.CRUD2();
            DataTable dt = new DataTable();
            crud.data(dt, v);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = v;
            comboBox.ValueMember = v;
        }

        Capa_VistaContabilidad.CRUD2 crud = new Capa_VistaContabilidad.CRUD2();
        private void button1_Click(object sender, EventArgs e)
        {
            float _Pk, _Edi, _Mue,  _Equi,  _Maqui,  _Herra,  _Eqco;


            _Pk = float.Parse(textBox7.Text);
            _Edi = float.Parse(textBox1.Text);
            _Mue = float.Parse(textBox2.Text);
            _Equi = float.Parse(textBox3.Text);
            _Maqui = float.Parse(textBox6.Text);
            _Herra = float.Parse(textBox5.Text);
            _Eqco = float.Parse(textBox4.Text);

            bool resultado = crud.InsertProducto(_Pk, _Edi, _Mue, _Equi, _Maqui, _Herra, _Eqco);
            if (resultado)
            {
                MessageBox.Show ("Dartos ingresados") ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float _Pk, _Edi, _Mue, _Equi, _Maqui, _Herra, _Eqco;


            _Pk = float.Parse(textBox7.Text);
            _Edi = float.Parse(textBox1.Text);
            _Mue = float.Parse(textBox2.Text);
            _Equi = float.Parse(textBox3.Text);
            _Maqui = float.Parse(textBox6.Text);
            _Herra = float.Parse(textBox5.Text);
            _Eqco = float.Parse(textBox4.Text);

            bool resultado = crud.UpdateProducto(_Pk, _Edi, _Mue, _Equi, _Maqui, _Herra, _Eqco);
            if (resultado)
            {
                MessageBox.Show("Dartos ingresados");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float _Pk ;


            _Pk = float.Parse(textBox7.Text);
            
            bool resultado = crud.DeleteProducto(_Pk);
            if (resultado)
            {
                MessageBox.Show("Dartos eliminado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String col = "";
            String data = "";
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        if (string.IsNullOrEmpty(textBox3.Text))
                        {
                            if (string.IsNullOrEmpty(textBox6.Text))
                            {
                                if (string.IsNullOrEmpty(textBox5.Text))
                                {
                                    if (string.IsNullOrEmpty(textBox4.Text))
                                    {
                                        String textalert = " El campo buscar, se encuentra vacio. Debe llenar un solo campo para realizar la busqueda";
                                        MessageBox.Show(textalert);
                                    }
                                    else
                                    {
                                        data = textBox4.Text;
                                        col = "EquipoComputo";
                                    }
                                }
                                else
                                {
                                    data = textBox5.Text;
                                    col = "Herramientas";
                                }
                            }
                            else
                            {
                                data = textBox6.Text;
                                col = "Maquinaria";
                            }
                        }
                        else
                        {
                            data = textBox3.Text;
                            col = "Equipos";
                        }
                    }
                    else
                    {
                        data = textBox2.Text;
                        col = "Muebles";
                    }
                }
                else
                {
                    data = textBox7.Text;
                    col = "Edificaciones";
                }
            }
            else
            {
                data = textBox7.Text;
                col = "Codigo";
            }
            DataTable dt = new DataTable();
            //crud.BuscarProducto(data, col, dt);
            crud.BuscarDato(data, col, dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            String table = "";
            DataTable dt = new DataTable();
            table = "tbl_EstadosFinancieros";
            crud.ActualizarT(table, dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void MantinimientoEstadosFinancieros_Load(object sender, EventArgs e)
        {
            //string dta = "nombre_contador";
            //Cargarcombo(comboBox7, dta);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
