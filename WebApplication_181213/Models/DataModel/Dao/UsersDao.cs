using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_181213.Models.DataModel.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace WebApplication_181213.Models.DataModel.Dao
{
    public class UsersDao:IDao
    {
        public List<T> Query<T>()
        {
            throw new NotImplementedException();
        }

        public List<Users> QueryAll()
        {
            using(IDbConnection db
                =new SqlConnection(ConfigurationManager.ConnectionStrings["DataDemo"].ConnectionString))
            {
                return (List<Entity.Users>)db.Query("select * from Users");
            }
            
        }

        public List<Entity.Users> QueryAll<Users>()
        {
            using (IDbConnection db
                = new SqlConnection(ConfigurationManager.ConnectionStrings["DataDemo"].ConnectionString))
            {
                return (List<Entity.Users>)db.Query("select * from Users");
            }
        }

        List<T> IDao.QueryAll<T>()
        {
            throw new NotImplementedException();
        }
    }
}