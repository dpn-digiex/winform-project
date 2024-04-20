using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemTraoDoiDoCu._Repositories
{
    internal class OrderRepository : BaseRepository
    {
        public OrderRepository()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
