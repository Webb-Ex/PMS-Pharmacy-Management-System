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
    public class OBilling
    {
        string con = "server=127.0.0.1;database=pharmacydb;uid=root;pwd=khan61814;";
        public int IBilling(Billing Bill)
        {
            int count;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                using (MySqlCommand cmd = new MySqlCommand("InsBill", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@id", Bill.ID);
                    cmd.Parameters.AddWithValue("@Cname", Bill.Name);
                    cmd.Parameters.AddWithValue("@Icode", Bill.ICode);
                    cmd.Parameters.AddWithValue("@IQuant", Bill.IQuantity);
                    cmd.Parameters.AddWithValue("@OStatus", Bill.Ostatus);
                    cmd.Parameters.AddWithValue("@SDis", Bill.SDiscount);
                    cmd.Parameters.AddWithValue("@STax", Bill.Stax);
                    cmd.Parameters.AddWithValue("@TotalAmount", Bill.Totalamount);
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }

        
       
    }
}

