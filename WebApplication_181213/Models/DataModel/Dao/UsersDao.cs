using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_181213.Models.DataModel.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Collections;
using System.IO;

namespace WebApplication_181213.Models.DataModel.Dao
{
    public class UsersDao : IDao<Users>
    {
        

        public List<Users> Query()
        {
            throw new NotImplementedException();
        }

        public List<Users> QueryAll()
        {
            using (IDbConnection db
                = new SqlConnection(ConfigurationManager.ConnectionStrings["DataDemo"].ConnectionString))
            {
                IEnumerable ts= db.Query<Users>("select * from Users");
                return (List<Users>)ts;
            }
            
        }

        public Users QueryOne()
        {
            return new Users();
        }

        public void Test()
        {
            FileStream file = new FileStream(@"D:\vs\ASP.NET\WebApplication_181213\WebApplication_181213\test.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(file);
            writer.Write("");
            writer.Flush();
            writer.Close();
            file.Close();
        }
        
    }
}