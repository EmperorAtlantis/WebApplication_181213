using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_181213.Models.DataModel.Dao
{
    public interface IDao<T>
    {
        
        List<T> Query();
        List<T> QueryAll();
        T QueryOne();
    }
}
