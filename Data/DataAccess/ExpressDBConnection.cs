using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;


namespace ExpressDLL.DataAccess
{
    //public static class ExpressDBConnextion
    //{
    //    // get connection string
    //    public static string GetConnectionString(string name = "DefaultConnection")
    //    {

    //        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    //    }
            
    //    // add object
    //    public static void SaveData<T>(string sql, T data)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            cnn.Execute(sql, data);
    //        }

    //    }

    //    public static void DeleteData<T>(string sql)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            cnn.Execute(sql);
    //        }

    //    }

    //    // load all objects
    //    public static List<T> LoadData<T>(string sql)
    //    {

    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            return cnn.Query<T>(sql).ToList();
    //        }

    //    }

    //    // search for an object

    //    public static List<T> FindData<T>(string sql)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {


    //            return cnn.Query<T>(sql).ToList();
    //        }

    //    }



    //    // search over 2 params



    //    // Get My...

    //    public static T LoadMy<T>(string id, string db, string ColoumnNmae)
    //    {
    //        string sql = $"Select * from [dbo].[{db}] Where ({ColoumnNmae} = '{id}');";
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            return cnn.QueryFirstOrDefault<T>(sql);
    //        }
    //    }
    //    public static T LoadMyOne<T>(string AccountId, string DBNAme)
    //    {
    //        string sql = $"Select * from [dbo].[{DBNAme}] Where (AccountId = '{AccountId}');";
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            return cnn.QueryFirstOrDefault<T>(sql);
    //        }

    //    }


    //    public static List<T> LoadMy<T>(string AccountId, string DBName)
    //    {
    //        string sql = $"Select * from [dbo].[{DBName}] Where (SenderId = '{AccountId}');";

    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            return cnn.Query<T>(sql).ToList();
    //        }

    //    }

    //    public static void UpdateData<T>(string sql)
    //    {
    //        using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
    //        {

    //            cnn.Execute(sql);
    //        }

    //    }

    //}
}
