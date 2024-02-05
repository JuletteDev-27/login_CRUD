using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace login_crud_dashboard
{
    public partial class Form1 : Form
    {
        private string dbconn_string = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        private string excel_saveLoc = ConfigurationManager.AppSettings["excelfilesaveloc"];
        

        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, object> GetUseraccountInfo(string user_accountid) 
        {
            Dictionary<string, object> useraccountinfo = new Dictionary<string, object>();

            using (SqlConnection dbconn = new SqlConnection(dbconn_string)) 
            {
                dbconn.Open();
                string getuseraccountinfo = "SELECT " +
                    "user_accountid as 'uid', " +
                    "user_accountname as 'uname', " +
                    "user_accountpassword as 'upass' " +
                    "FROM table_useraccounts" +
                    $" WHERE user_accountid = {user_accountid}";

                using (SqlCommand query = new SqlCommand(getuseraccountinfo, dbconn)) 
                {
                    using (SqlDataReader reader = query.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            useraccountinfo["uid"] = reader["uid"];
                            useraccountinfo["uname"] = reader["uname"];
                            useraccountinfo["upass"] = reader["upass"];
                        }
                    }
                }

                dbconn.Close();
            }


                return useraccountinfo;
        }

        private bool checkuserexists(string user_accountid) 
        {
            var checkresult = 0;

            using (SqlConnection dbconn = new SqlConnection(dbconn_string))
            {
                dbconn.Open();
                string getuseraccountinfo = "SELECT COUNT(user_accountid) as 'result'" +
                    " FROM table_useraccounts"+
                    $" WHERE user_accountid = {user_accountid}";

                using (SqlCommand query = new SqlCommand(getuseraccountinfo, dbconn))
                {
                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkresult = Int32.Parse(reader["result"].ToString());
                        }
                    }
                }

                dbconn.Close();
            }

            if (checkresult != 1) 
            {
                return false;
            }

            return true;
        }
        private void table_useraccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_useraccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.table_useraccounts' table. You can move, or remove it, as needed.
            this.table_useraccountsTableAdapter.Fill(this.database1DataSet.table_useraccounts);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var input_userid = tbx_search.Text;

            if (!checkuserexists(input_userid)) 
            {
                MessageBox.Show("USER WITH THIS USER ID DOES NOT EXISTS!");
                tbx_search.Text = "";
                return;
            }

            Dictionary<string, object> uinfo = GetUseraccountInfo(input_userid);
            user_accountidTextBox.Text = uinfo["uid"].ToString();
            user_accountnameTextBox.Text = uinfo["uname"].ToString();
            user_accountpasswordTextBox.Text = uinfo["upass"].ToString();
        }

        private void cbx_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_showpass.Checked) 
            {
                user_accountpasswordTextBox.PasswordChar = '\0';
                return;
            }

            user_accountpasswordTextBox.PasswordChar = '*';
            return;

        }

        private Dictionary<string, List<string>> GetAllUserAccountInfo() 
        {
            Dictionary<string, List<string>> alluseraccountinfo = new Dictionary<string, List<string>>();

            using (SqlConnection dbconn = new SqlConnection(dbconn_string)) 
            {
                dbconn.Open();
                string getalluseraccountinfoquery = "SELECT user_accountid as 'uid', user_accountname as 'uname', user_accountpassword as 'upass' FROM table_useraccounts";

                using (SqlCommand query = new SqlCommand(getalluseraccountinfoquery, dbconn)) 
                {
                    using (SqlDataReader reader = query.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            alluseraccountinfo[reader["uid"].ToString()] = new List<string> { reader["uid"].ToString(), reader["uname"].ToString(), reader["upass"].ToString() };
                        }
                    }
                }
                dbconn.Close();
            }

                return alluseraccountinfo;
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            int column = 2;

           

            using (var package = new ExcelPackage()) 
            {
                var worksheet = package.Workbook.Worksheets.Add("all_userAccounts");
                worksheet.Cells["A1"].Value = "user_accountid";
                worksheet.Cells["B1"].Value = "user_accountname";
                worksheet.Cells["C1"].Value = "user_accountpassword";

                foreach (KeyValuePair<string, List<string>> item in GetAllUserAccountInfo())
                {
                    string key = item.Key;
                    List<string> values = item.Value;

                    worksheet.Cells[$"A{column}"].Value = key;
                    worksheet.Cells[$"B{column}"].Value = values[1];
                    worksheet.Cells[$"C{column}"].Value = values[2];

                    column++;
                }

                MessageBox.Show(excel_saveLoc);

                string fileinfo = $"{excel_saveLoc}test.xlsx";
                package.SaveAs(new FileInfo(fileinfo));
            }

        }
    }
}
