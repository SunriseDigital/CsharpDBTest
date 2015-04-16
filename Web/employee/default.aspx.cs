using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;

namespace Web.employee
{
    public partial class Default : System.Web.UI.Page
    {
        protected List<Dictionary<string, string>> employees;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM employee ORDER BY salary DESC";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                //現在の結果セットのカラム情報を取得
                DataTable schemaTable = reader.GetSchemaTable();

                employees = new List<Dictionary<string, string>>();
                foreach (IDataRecord record in reader)
                {
                    int key = 0;
                    Dictionary<string, string> employee = new Dictionary<string, string>();
                    employees.Add(employee);

                    //{カラム名 => 値}のDictionaryを作成
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        employee[row["ColumnName"].ToString()] = record.GetValue(key++).ToString();
                    }
                }
 
            }
        }
    }
}