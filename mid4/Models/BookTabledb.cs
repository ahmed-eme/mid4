using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using mid4.Models;

namespace mid4.Models
{
    public class BookTabledb
    {
       SqlConnection con = new SqlConnection("Data Source=(localdb)//ProjectsV13;Initial Catalog=RestaurantData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public string savercord(BookTableModels Book)
        {
            try
            {
                SqlCommand com = new SqlCommand("Sp_Tablebook_Add", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@phone", Book.Phone);
                com.Parameters.AddWithValue("@Email", Book.Email);
                com.Parameters.AddWithValue("@Name", Book.Name);
                com.Parameters.AddWithValue("@Date", Book.Date);
                com.Parameters.AddWithValue("@Time", Book.Time);
                com.Parameters.AddWithValue("@people", Book.People);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("DN");

            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                
                
                }
                return(ex.Message.ToString());
            }
           
        }

    }
}