using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace DBTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(ConfigurationManager.ConnectionStrings);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
            {
                // 接続します。
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM employee ORDER BY salary DESC";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();

                List<Dictionary<string,string>> employees = new List<Dictionary<string, string>>();
                foreach(IDataRecord record in reader)
                {
                    int key = 0;
                    Dictionary<string, string> employee = new Dictionary<string, string>();
                    employees.Add(employee);
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        employee[row["ColumnName"].ToString()] = record.GetValue(key++).ToString();
                    }
                }

                foreach(Dictionary<string, string> emp in employees)
                {
                    Console.WriteLine(String.Format("{0} {1} {2} {3}", emp["employee_id"], emp["name"], emp["salary"], emp["employee_date"]));
                }
                reader.Close();

            }
        }
    }
}
