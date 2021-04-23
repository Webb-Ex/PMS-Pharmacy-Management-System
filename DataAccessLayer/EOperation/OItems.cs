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
    public class OItems
    {

        string con = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        public int IItems(Items itm)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO items VALUES (@id,@name,@Comp_code,@pack_size,@Tprize,@Rprize,@STax,@SDis,@Stock,@SCode)", conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", itm.ID);
                    cmd.Parameters.AddWithValue("@name", itm.Name);
                    cmd.Parameters.AddWithValue("@Comp_code", itm.CCode);
                    cmd.Parameters.AddWithValue("@pack_size", itm.PSize);
                    cmd.Parameters.AddWithValue("@Tprize", itm.TPrize);
                    cmd.Parameters.AddWithValue("@Rprize", itm.RPrize);
                    cmd.Parameters.AddWithValue("@STax", itm.RPrize);
                    cmd.Parameters.AddWithValue("@SDis", itm.SDiscount);
                    cmd.Parameters.AddWithValue("@Stock", itm.Stock);
                    cmd.Parameters.AddWithValue("@SCode", itm.SCode);
                    
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }

        public int UItems(Items itm)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("EditItems", conn))
                {
                    
                    cmd.Parameters.AddWithValue("@I_id", itm.ID);
                    cmd.Parameters.AddWithValue("@I_name", itm.Name);
                    cmd.Parameters.AddWithValue("@I_code", itm.CCode);
                    cmd.Parameters.AddWithValue("@I_pack_size", itm.PSize);
                    cmd.Parameters.AddWithValue("@I_Tprize", itm.TPrize);
                    cmd.Parameters.AddWithValue("@I_Rprize", itm.RPrize);
                    cmd.Parameters.AddWithValue("@I_SDis", itm.SDiscount);
                    cmd.Parameters.AddWithValue("@I_Stock", itm.Stock);
                    cmd.Parameters.AddWithValue("@I_SCode", itm.SCode);
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
                string query = "select * from viewitems";
                sqlcon.Open();
                MySqlDataAdapter sqldata = new MySqlDataAdapter(query, sqlcon);
                DataTable db = new DataTable();
                sqldata.Fill(db);
                return db;
            }

        }
    }
}

