using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication_181213.Models.DataModel.Entity
{
    public class Users
    {
        public Users(){ }

        public Users(string name, string pwd)
        {
            Name = name;
            Pwd = pwd;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Pwd { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}