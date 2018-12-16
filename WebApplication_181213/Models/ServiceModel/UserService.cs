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
        private IDao<Users> dao = new UsersDao();
        public List<Users> GetAllUsers()
        {
            return dao.QueryAll();
        }

        public bool CheckUser(Users user)
        {
            bool check = false;
            List<Users> lu = GetAllUsers();
            foreach (Users u in lu)
            {
                if (u.Name == user.Name && u.Pwd == user.Pwd)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}