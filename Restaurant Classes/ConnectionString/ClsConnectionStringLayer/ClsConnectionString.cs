using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsConnectionStringLayer
{
    public class ClsConnectionString
    {
        private const string ConnectionString = "Server=.;Database=DBRestaurant;User Id=sa;Password=sa123456";

        public static string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
