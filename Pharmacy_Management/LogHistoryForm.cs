using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class LogHistoryForm : Form
    {
        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        readonly string userRole = MyAppContext.UserRole;
        readonly string userId = MyAppContext.EmpID;

        string loginText = "login";
        public LogHistoryForm()
        {
            InitializeComponent();
        }

        public void populate()
        {
            dbConnection.Open();

            string Myquery = "select * from LoginHistory_tbl WHERE EmpId = '" + userId + "' AND LogType = '" + loginText + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, dbConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            LogHistoryDataGridView.DataSource = ds.Tables[0];
            dbConnection.Close();

        }

        private void LogHistoryForm_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("LogHistory", this);
            populate();
            MyAppContext.LoginCount = LogHistoryDataGridView.RowCount;
            
        }

        private void log_back_icon_Click(object sender, EventArgs e)
        {
            FormManager.GoBack();
            this.Hide();
        }


    }
}
