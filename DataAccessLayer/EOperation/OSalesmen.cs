using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;
using DataAccessLayer.Entities;
using DataAccessLayer.Assets;

namespace DataAccessLayer.EOperation
{
    public class OSalesmen
    {
        string con = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        public int ISalesmen(Salesmen sale)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO salesman VALUES (@SaleID,@SaleName,@SaleAddress,@SalePPhone,@SaleSPhone);", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@SaleID", sale.ID);
                    cmd.Parameters.AddWithValue("@SaleName", sale.Name);
                    cmd.Parameters.AddWithValue("@SaleAddress", sale.Address);
                    cmd.Parameters.AddWithValue("@SalePPhone", sale.PPhone);
                    cmd.Parameters.AddWithValue("@SaleSPhone", sale.SPhone);
                    

                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }


        public int USalesmen(Salesmen sale)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("EditSales", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Sid", sale.ID);
                    cmd.Parameters.AddWithValue("@Sname", sale.Name);
                    cmd.Parameters.AddWithValue("@SAddress", sale.Address);
                    cmd.Parameters.AddWithValue("@Sp1", sale.PPhone);
                    cmd.Parameters.AddWithValue("@Sp2", sale.SPhone);
                    
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }


        public object view()
        {
            using (MySqlConnection sqlcon = new MySqlConnection(con))
            {
                string query = "select * from viewsales";
                sqlcon.Open();
                MySqlDataAdapter sqldata = new MySqlDataAdapter(query, sqlcon);
                DataTable db = new DataTable();
                sqldata.Fill(db);
                return db;
            }

        }
    }


}
