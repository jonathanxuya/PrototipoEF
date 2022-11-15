using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Capa_VistaContabilidad
{
    class CRUD
    {
        public bool InsertProducto(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_ventas (PK_ventas,fecha,elementos,total,nit,cliente,tienda)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@PK_ventas", OdbcType.Int).Value = _Pk;
                    cmd.Parameters.Add("@fecha", OdbcType.Date).Value = _Edi;
                    cmd.Parameters.Add("@elementos", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@total", OdbcType.Int).Value = _Equi;
                    cmd.Parameters.Add("@nit", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@cliente", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@tienda", OdbcType.VarChar).Value = _Eqco;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool UpdateProducto(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_ventas SET tbl_ventas.fecha = ?, tbl_ventas.elementos = ?, tbl_ventas.total = ?, tbl_ventas.nit = ? , tbl_ventas.cliente = ? , tbl_ventas.tienda = ? WHERE tbl_ventas.PK_ventas = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.Add("@fecha", OdbcType.Date).Value = _Edi;
                    cmd.Parameters.Add("@elementos", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@total", OdbcType.Int).Value = _Equi;
                    cmd.Parameters.Add("@nit", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@cliente", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@tienda", OdbcType.VarChar).Value = _Eqco;
                    cmd.Parameters.Add("@PK_ventas", OdbcType.Int).Value = _Pk;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteProducto(string _Pk)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_ventas WHERE tbl_ventas.PK_ventas = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@tbl_ventas", OdbcType.Int).Value = _Pk;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable SelectProducto()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_ventas;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarDato(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_ventas WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }

        public DataTable ActualizarT(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }

    }
}
