using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.Assets;
using MySQL.Data.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;

    
namespace DataAccessLayer.EOperation
{
    public class OCustomer
    {
        string con="server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";            
        public int ICustomer(Customer Cus)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO customer VALUES (@CusID,@CusName,@CusAddress,@CusPPhone,@CusSPhone,@CusACode,@CusSmanID)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CusID", Cus.ID);
                    cmd.Parameters.AddWithValue("@CusName", Cus.Name);
                    cmd.Parameters.AddWithValue("@CusAddress", Cus.Address);
                    cmd.Parameters.AddWithValue("@CusPPhone", Cus.PPhone);
                    cmd.Parameters.AddWithValue("@CusSPhone", Cus.SPhone);
                    cmd.Parameters.AddWithValue("@CusACode",  Cus.ACode);
                    cmd.Parameters.AddWithValue("@CusSmanID", Cus.SmanID);
                    
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }

        public int UCustomer(Customer Cus)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("EditCustomer", conn))
                {
                    
                    cmd.CommandType  = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@C_id", Cus.ID);
                    cmd.Parameters.AddWithValue("@C_name", Cus.Name);
                    cmd.Parameters.AddWithValue("@C_address", Cus.Address);
                    cmd.Parameters.AddWithValue("@C_p1", Cus.PPhone);
                    cmd.Parameters.AddWithValue("@C_p2", Cus.SPhone);
                    cmd.Parameters.AddWithValue("@C_areaC", Cus.ACode);
                    cmd.Parameters.AddWithValue("@C_SalesID", Cus.SmanID);
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
                string query = "select * from viewcustomer";
                sqlcon.Open();
                MySqlDataAdapter sqldata = new MySqlDataAdapter(query, sqlcon);
                DataTable db = new DataTable();
                sqldata.Fill(db);
                return db;
            }
            
        }
    }
}
