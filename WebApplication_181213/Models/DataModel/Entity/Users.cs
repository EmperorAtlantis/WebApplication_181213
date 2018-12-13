using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication_181213.Models.DataModel.Entity
{
    public class Users
    {
        private long Id { get; set; }

        private string Name { get; set; }

        private string Pwd { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}