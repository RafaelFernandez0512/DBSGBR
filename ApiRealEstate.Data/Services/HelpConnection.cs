using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ApiRealEstate.Data.Services
{
   public class HelpConnection
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public HelpConnection()
        {
            con.ConnectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=SGBR;Integrated Security=True";
            cmd.Connection = con;
        }
        public void Openconnection()
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        public SqlCommand Getcommand
        {
            get
            {
                return cmd;
            }
        }
    }
}
