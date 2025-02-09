using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace HotelBookingApp
{
    class Connection
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=FARREL;Initial Catalog=HotelManagement;Integrated Security=True;Trust Server Certificate=True";
            return Conn;
        }
    }
}
