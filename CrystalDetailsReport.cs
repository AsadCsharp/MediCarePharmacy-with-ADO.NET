using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare
{
    public partial class CrystalDetailsReport : Form
    {
        public CrystalDetailsReport()
        {
            InitializeComponent();
        }

        private void CrystalDetailsReport_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = null;
            using (SqlConnection con = new SqlConnection(ConnectionHelper.MediCon))
            {
                con.Open();
                string q = "select * from SalesItem";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds, "SalesItem");
                CrystalReport1 cr1 = new CrystalReport1();
                cr1.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr1;
                con.Close();
                crystalReportViewer1.Refresh();
                con.Close();

            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
