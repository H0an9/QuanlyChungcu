using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DataConnect
{
    public class DataConnect
    {
        private SqlConnection conn;

        public DataConnect()           // khởi tạo kết nối
        {
            conn = new SqlConnection("");
        }

        public DataTable GetData(String str)         //lấy dữ liệu
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }


    }
}
