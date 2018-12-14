using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_181213.Models.DataModel.Dao;
using WebApplication_181213.Models.DataModel.Entity;

namespace WebApplication_181213.Models.ServiceModel
{
    public class UserService
    {
        private IDao dao;
        public List<Users> GetAllUsers()
        {
            dao = new UsersDao();

        }
    }
}