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
    public class OSupplier
    {
        string con = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        public int ISupplier(Supplier spl)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO supplier VALUES (@id,@name,@Address,@p1,@p2,@ACode)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", spl.ID);
                    cmd.Parameters.AddWithValue("@name", spl.Name);
                    cmd.Parameters.AddWithValue("@Address", spl.Address);
                    cmd.Parameters.AddWithValue("@p1", spl.PPhone);
                    cmd.Parameters.AddWithValue("@p2", spl.SPhone);
                    cmd.Parameters.AddWithValue("@ACode", spl.ACode);
                    

                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }

        public int USupplier(Supplier spl)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("EditSupplier", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SCode", spl.ID);
                    cmd.Parameters.AddWithValue("@Sname", spl.Name);
                    cmd.Parameters.AddWithValue("@SAddress", spl.Address);
                    cmd.Parameters.AddWithValue("@Sp1", spl.PPhone);
                    cmd.Parameters.AddWithValue("@Sp2", spl.SPhone);
                    cmd.Parameters.AddWithValue("@SAreaC", spl.ACode);
                    
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
                string query = "select * from viewsupplier";
                sqlcon.Open();
                MySqlDataAdapter sqldata = new MySqlDataAdapter(query, sqlcon);
                DataTable db = new DataTable();
                sqldata.Fill(db);
                return db;
            }

        }
    }
}
