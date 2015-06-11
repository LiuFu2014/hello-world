using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlBackUpOrRestore
{
    public class SqlHelper
    {
        /// <summary>
        /// 数据库备份
        /// Datas the backup configuration database.
        /// </summary>
        /// <param name="backupFolder">备份路径（不包含文件名）The backup folder.</param>
        /// <param name="dbName">备份数据库名Name of the database.</param>
        /// <param name="nameSuffix">命名后缀The name suffix.</param>
        /// <param name="connStr">连接字符串The connection string.</param>
        /// <returns></returns>
        public static bool DataBackupConfigDB(string backupFolder, string dbName, string nameSuffix, string connStr)
        {
            //获取配置文件中sql数据库名
            //string dbName = "XinYaDB";
            //string name = dbName + DateTime.Now.ToString("yyyyMMddHHmmss");
            string name = dbName + nameSuffix;
            string procname;
            string sql;
            //创建连接对象
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();        //打开数据库连接
            //删除逻辑备份设备，但不会删掉备份的数据库文件
            procname = "sp_dropdevice";
            SqlCommand sqlcmd1 = new SqlCommand(procname, conn);
            sqlcmd1.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlpar = new SqlParameter();
            sqlpar = sqlcmd1.Parameters.Add("@logicalname", SqlDbType.VarChar, 20);
            sqlpar.Direction = ParameterDirection.Input;
            sqlpar.Value = dbName;
            try        //如果逻辑设备不存在，略去错误
            {
                sqlcmd1.ExecuteNonQuery();
            }
            catch
            {
                //MessageBox.Show("错误的备份文件目录");
            }
            //创建逻辑备份设备
            procname = "sp_addumpdevice";
            SqlCommand sqlcmd2 = new SqlCommand(procname, conn);
            sqlcmd2.CommandType = CommandType.StoredProcedure;
            sqlpar = sqlcmd2.Parameters.Add("@devtype", SqlDbType.VarChar, 20);
            sqlpar.Direction = ParameterDirection.Input;
            sqlpar.Value = "disk";
            sqlpar = sqlcmd2.Parameters.Add("@logicalname", SqlDbType.VarChar, 20);//逻辑设备名
            sqlpar.Direction = ParameterDirection.Input;
            sqlpar.Value = dbName;
            sqlpar = sqlcmd2.Parameters.Add("@physicalname", SqlDbType.NVarChar, 260);//物理设备名
            sqlpar.Direction = ParameterDirection.Input;
            sqlpar.Value = backupFolder + name + ".bak";
            try
            {
                int i = sqlcmd2.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                string str = err.Message;
            }
            //备份数据库到指定的数据库文件(完全备份)
            sql = "BACKUP DATABASE " + dbName + " TO " + dbName + " WITH INIT";
            SqlCommand sqlcmd3 = new SqlCommand(sql, conn);
            sqlcmd3.CommandType = CommandType.Text;
            try
            {
                sqlcmd3.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                string str = err.Message;
                conn.Close();
                return false;
            }
            conn.Close();//关闭数据库连接
            return true;
        }

        /// <summary>
        /// 数据库还原
        /// Datas the restore configuration database.
        /// </summary>
        /// <param name="dbFile">路径包含文件名The database file.</param>
        /// <param name="dbName">数据库名Name of the database.</param>
        /// <param name="connStr">连接字符串The connection string.</param>
        /// <returns></returns>
        public static bool DataRestoreConfigDB(string dbFile, string dbName, string connStr)
        {
            //sql数据库名
            //string dbName = "XinYaDB";
            //创建连接对象
            SqlConnection conn = new SqlConnection(connStr);
            //还原指定的数据库文件
            string sql = string.Format("use master ;declare @s varchar(8000);select @s=isnull(@s,'')+' kill '+rtrim(spID) from master..sysprocesses where dbid=db_id('{0}');select @s;exec(@s) ;RESTORE DATABASE {1} FROM DISK = N'{2}' with replace", dbName, dbName, dbFile);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                string str = err.Message;
                conn.Close();
                return false;
            }
            conn.Close();//关闭数据库连接
            return true;
        }
    }
}
