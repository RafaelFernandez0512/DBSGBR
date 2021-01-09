using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Remsys.Data.Services
{
    public class BaseService: HelpConnection
    {
        public  string CommandGrud(string spname, params object[] values)

        {
            Openconnection();
            Getcommand.CommandType = CommandType.StoredProcedure;
            Getcommand.CommandText = spname;
            SqlCommandBuilder.DeriveParameters(Getcommand);
            int i = 0, j = 0;
            foreach (SqlParameter spram in Getcommand.Parameters)
            {
                if (j > 0)
                {
                    spram.Value = values[i];
                    i++;
                }
                j++;
            }
            Getcommand.ExecuteNonQuery();
            return "Success";
        }

        public  DataSet Getdata(string spname, params object[] values)
        {
            Openconnection();
            Getcommand.CommandType = CommandType.StoredProcedure;
            Getcommand.CommandText = spname;
            SqlCommandBuilder.DeriveParameters(Getcommand);
            int i = 0, j = 0;
            foreach (SqlParameter spram in Getcommand.Parameters)
            {
                if (j > 0)
                {
                    spram.Value = values[i];
                    i++;
                }
                j++;
            }

            SqlDataAdapter ad = new SqlDataAdapter();
            DataSet ds = new DataSet();
            ad.SelectCommand = Getcommand;
            ad.Fill(ds);
            return ds;
        }

    }
}
