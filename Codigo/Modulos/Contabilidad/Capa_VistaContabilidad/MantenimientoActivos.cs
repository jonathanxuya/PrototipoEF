using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_ControladorContabilidad;

namespace Capa_VistaContabilidad
{
    public partial class MantenimientoActivos : Form
    {
        public MantenimientoActivos()
        {
            InitializeComponent();
        }
       

       Capa_VistaContabilidad.CRUD crud = new Capa_VistaContabilidad.CRUD();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = crud.SelectProducto();
            foreach (DataRow item in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] { item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString(), item[5].ToString() , item[6].ToString()});
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertProducto(textBox7.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[]{ textBox7.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text });
            }
            if (resultado)
            {
                MessageBox.Show("Dato agregado");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool resultado = crud.UpdateProducto(textBox7.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool resultado = crud.DeleteProducto(textBox7.Text);
            if (resultado)
            {
                MessageBox.Show("Dato eliminado");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            /*  bool resultado = crud.SelectProducto(dataGridView1.Rows);
              if (resultado)
              {
                  dataGridView1.Rows.Add(new object[]{textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text});
              }*/
            String col = "";
            String data = "";
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                if (string.IsNullOrEmpty(dateTimePicker1.Text))
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
                                        col = "tienda";
                                    }
                                }
                                else
                                {
                                    data = textBox5.Text;
                                    col = "cliente";
                                }
                            }
                            else
                            {
                                data = textBox6.Text;
                                col = "nit";
                            }
                        }
                        else
                        {
                            data = textBox3.Text;
                            col = "total";
                        }
                    }
                    else
                    {
                        data = textBox2.Text;
                        col = "elementos";
                    }
                }
                else
                {
                    data = dateTimePicker1.Text;
                    col = "fecha";
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
            table = "tbl_ventas";
            crud.ActualizarT(table,dt);
            dataGridView1.DataSource = dt;
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
