using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Data.Common;

namespace ADOTest
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        private string str = "data source=192.168.1.8;initial catalog=XinYaDB;user id=sa;password=1qaz!QAZ;";

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0.98;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime begin = System.DateTime.Now;
            SqlConnection conn = new SqlConnection(str);
            using (conn)
            {
                conn.Open();
                SqlCommand com = new SqlCommand("select * from TB_WorkDtlForEachStation", conn);
                SqlDataAdapter a = new SqlDataAdapter(com);
                DataTable at = new DataTable();
                a.Fill(at);
               string c= at.Rows[0][0].ToString();
                
                dataGridView1.DataSource = at;
            }
            DateTime end = System.DateTime.Now;
            label1.Text = (end - begin).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime begin = System.DateTime.Now;
            SqlConnection conn = new SqlConnection(str);
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "testpro";
                cmd.Connection = conn;
                cmd.Parameters.Add(new SqlParameter("@myint", SqlDbType.Int));
                cmd.Parameters["@myint"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                da = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                //这个可以返回存储过程中的多个数据集
                da.Fill(ds);
                da.SelectCommand = cmd;
                da.UpdateCommand = builder.GetUpdateCommand();
                
                dataGridView1.DataSource = ds.Tables[0];
                //IAsyncResult read = cmd.BeginExecuteReader();
                //textBox1.AppendText("异步执行中！！！");
                //SqlDataReader reads= cmd.EndExecuteReader(read);
                //cmd.ExecuteNonQuery();
                //textBox1.AppendText(cmd.Parameters["@myint"].Value.ToString() + "\r\t");
                //textBox1.AppendText(cmd.Parameters["@RETURN_VALUE"].Value.ToString() + "\r\t");
                //while (reads.Read())
                //{
                //    textBox1.AppendText(reads[0].ToString() + "\r\n");
                //}
            }
            DateTime end = System.DateTime.Now;
            label1.Text = (end - begin).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DateTime begin = System.DateTime.Now;
            SqlConnection conn = new SqlConnection(str);
            using (conn)
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from TB_User",conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.UpdateCommand = builder.GetUpdateCommand(); 
                //为何这里会报错？？？？？
                //重新定义适配器对象即可解决报错
                da.Update(dt);

            }
            DateTime end = System.DateTime.Now;
            label1.Text = (end - begin).ToString();

        }

        /// <summary>
        /// 用DataTable对象更新数据库
        /// 1.DataTable的列可以多于数据库的列，不能少于数据库的列 
        /// 2.不能用一个DataTable更新两个表的时候，需要调用两次GetChanges()方法获取两个DataTable来更新两个表
        /// 3.一个DataTable更新之后，需要用AcceptChanges来消除状态，然后再提交更新，重复更新会爆并发性错误
        /// </summary>
        /// <param name="ClientDataTable">用来跟更新的DataTable</param>
        /// <param name="SQLString">用来匹配DataTable格式的查询Sql语句</param>
        /// <returns>影响的行数</returns>
        //public int SubmitDataTable(DataTable ClientDataTable, string SQLString)
        //{
        //    int RowsCount = 0;
        //    if (ClientDataTable != null && ErrorMessage == null)
        //    {
        //        try
        //        {
        //            SetSqlStringCommond(SQLString);
        //            DbProviderFactory dbfactory = DbProviderFactories.GetFactory(dbProviderName);
        //            DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
        //            dbDataAdapter.SelectCommand = dbCommand;
        //            DbCommandBuilder DCB = dbfactory.CreateCommandBuilder();
        //            DCB.DataAdapter = dbDataAdapter;
        //            RowsCount = dbDataAdapter.Update(ClientDataTable);
        //            return RowsCount;
        //        }
        //        catch (Exception ex)
        //        {
        //            ShowException(ex);
        //            return 0;
        //        }
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

    }
}
