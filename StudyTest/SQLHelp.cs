using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace StudyTest
{
    class SQLHelp
    {
        readonly string _constr = System.Configuration.ConfigurationManager.ConnectionStrings["XinYaCon"].ToString();

        public DataSet SerBySQL(string sql)
        {
            DataSet datset = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(_constr))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader sqlreader = com.ExecuteReader();
                    while (sqlreader.Read())
                    {
                        for (int i = 0; i < sqlreader.FieldCount; i++)
                        {
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
            return datset;
        }

        /// <summary>
        /// Sers the by SQL datatable.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public DataTable SerBySQLDatatable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(_constr))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Procedures the specified pro name.
        /// </summary>
        /// <param name="proName">Name of the pro.</param>
        /// <param name="ID">The identifier.</param>
        /// <param name="Data">The data.</param>
        /// <returns></returns>
        public int Procedure(string proName, SqlParameter[] para)
        {
            using (SqlConnection conn = new SqlConnection(_constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(proName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@ID",ID));
                //cmd.Parameters.Add(new SqlParameter("@Data", Data));
                cmd.Parameters.Add(para);
                cmd.ExecuteNonQuery();

            }
            return 0;
        }

        /// <summary>
        /// Updates the by dt.
        /// </summary>
        /// <param name="dt">The dt.</param>
        public void UpdateByDt(DataTable dt)
        {
            if (_constr == null) return;
            using (SqlConnection conn = new SqlConnection(_constr))
            {
                conn.Open();
                //SqlDataAdapter da = new SqlDataAdapter(conn,);
            }
        }
    }
}


