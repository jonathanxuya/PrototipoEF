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
    class CRUD1
    {
        public bool InsertProducto(string _Pkp, string _Pkm, string _Pka, string _Pkc, string _NOMB, string _fech, string _des, string _te,string _ant, string _stat)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_presupuesto (PKidpresupuesto,PKidMoneda,PKidArea,PKidCuenta,nombre,fecha,descripcion,monto,anotacion,status)VALUE(?,?,?,?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.Int).Value = _Pkp;
                    cmd.Parameters.Add("@PKidMoneda", OdbcType.Int).Value = _Pkm;
                    cmd.Parameters.Add("@PKidArea", OdbcType.Int).Value = _Pka;
                    cmd.Parameters.Add("@PKidCuenta", OdbcType.Int).Value = _Pkc;
                    cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _NOMB;
                    cmd.Parameters.Add("@fecha", OdbcType.VarChar).Value = _fech;
                    cmd.Parameters.Add("@descripcion", OdbcType.VarChar).Value = _des;
                    cmd.Parameters.Add("@monto", OdbcType.VarChar).Value = _te;
                    cmd.Parameters.Add("@anotacion", OdbcType.VarChar).Value = _ant;
                    cmd.Parameters.Add("@status", OdbcType.VarChar).Value = _stat;
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


        public bool UpdateProducto(string _Pkp, string _Pkm, string _Pka, string _Pkc, string _NOMB, string _fech, string _des, string _te, string _ant, string _stat)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_presupuesto SET tbl_presupuesto.PKidMoneda = ?, tbl_presupuesto.PKidArea = ?, tbl_presupuesto.PKidCuenta = ?, tbl_presupuesto.nombre = ? , tbl_presupuesto.fecha = ? , tbl_presupuesto.descripcion = ? , tbl_presupuesto.monto = ? , tbl_presupuesto.anotacion = ? , tbl_presupuesto.status = ? WHERE tbl_presupuesto.PKidpresupuesto = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    
                    cmd.Parameters.Add("@PKidMoneda", OdbcType.Int).Value = _Pkm;
                    cmd.Parameters.Add("@PKidArea", OdbcType.Int).Value = _Pka;
                    cmd.Parameters.Add("@PKidCuenta", OdbcType.Int).Value = _Pkc;
                    cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _NOMB;
                    cmd.Parameters.Add("@fecha", OdbcType.VarChar).Value = _fech;
                    cmd.Parameters.Add("@descripcion", OdbcType.VarChar).Value = _des;
                    cmd.Parameters.Add("@monto", OdbcType.VarChar).Value = _te;
                    cmd.Parameters.Add("@anotacion", OdbcType.VarChar).Value = _ant;
                    cmd.Parameters.Add("@status", OdbcType.VarChar).Value = _stat;
                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.Int).Value = _Pkp;

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
                    string query = @"DELETE FROM tbl_presupuesto WHERE tbl_presupuesto.PKidpresupuesto = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.VarChar).Value = _Pk;
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
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_activosfijos;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarDato(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_presupuesto WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
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
                OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
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
