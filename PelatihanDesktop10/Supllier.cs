using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelatihanDesktop10.Controller
{
    internal class Supplier_Controller : Model.Connection
    {
        public DataTable tampilSupplier()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM supplier";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
    }
}
