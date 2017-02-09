using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ReportesWindows
{
    public partial class Form1 : Form
    {

        MySqlConnection myConexion = new MySqlConnection();
        string cadenaConexion;
        MySqlDataSet.ProductosMySqlDataTable dtMYsql = new MySqlDataSet.ProductosMySqlDataTable();
        
        public Form1()
        {
            InitializeComponent();
            iniciarConexion();
        }

        private void iniciarConexion()
        {
            try
            {
                cadenaConexion = "Server=localhost;Database=almacen; Uid=root; Pwd=''";
                myConexion.ConnectionString = cadenaConexion;
                myConexion.Open();
                //MessageBox.Show("conectado");
                MySqlCommand _comando = myConexion.CreateCommand();
                _comando.CommandText = "Select * from Productos";
                MySqlDataReader reader = _comando.ExecuteReader();
                dtMYsql.Load(reader);
                dataGridViewMysql.DataSource = dtMYsql;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("ERROR de conexion"+ex.Message );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            BarrasLabel.Text = codigotextBox.Text;
            CodigoLabel.Text= codigotextBox.Text;
        }

  
        private void FiltrarMYSQLbutton_Click(object sender, EventArgs e)
        {

            MySqlDataSet emDS = new MySqlDataSet();
       
            var ret = emDS.ProductosMySql;
            ret = dtMYsql;
            ReportDataSource rds = new ReportDataSource("ProductosMysql", ret.ToArray());
            rds.Name = "MySqlDataSet";
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ListaProductosMYSQL.rdlc";
            this.reportViewer1.LocalReport.ReportPath = @"ListaProductosMYSQL.rdlc";
            this.reportViewer1.RefreshReport();
        }

        private void FiltrarSQLServerbutton_Click(object sender, EventArgs e)
        {
            try
            {
                AlmacenDBDataSet.ProductosDataTable dt = new AlmacenDBDataSet.ProductosDataTable();
                AlmacenDBDataSetTableAdapters.ProductosTableAdapter da = new AlmacenDBDataSetTableAdapters.ProductosTableAdapter();
                da.Fill(dt);
                AlmacenDBDataSet emDS = new AlmacenDBDataSet();
                var ret = emDS.Productos;
                ret = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource DSReport = new ReportDataSource("Productos", ret.ToArray());
                DSReport.Name = "DataSet1";
                reportViewer1.LocalReport.DataSources.Add(DSReport);
                reportViewer1.LocalReport.ReportEmbeddedResource = "ListaProductos.rdlc";
                reportViewer1.LocalReport.ReportPath = @"ListaProductos.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
