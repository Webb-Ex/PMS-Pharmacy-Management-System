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
    public class OArea
    {
        string con = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        public int IArea(Area ar)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO area VALUES (@code,@name);", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@code", ar.ID);
                    cmd.Parameters.AddWithValue("@name", ar.Name);
                    
                    

                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }

        public int UArea(Area ar)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("EditArea", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@code", ar.ID);
                    cmd.Parameters.AddWithValue("@name", ar.Name);
             
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
                string query = "select * from viewarea";
                sqlcon.Open();
                MySqlDataAdapter sqldata = new MySqlDataAdapter(query, sqlcon);
                DataTable db = new DataTable();
                sqldata.Fill(db);
                return db;
            }

        }
    }
}
