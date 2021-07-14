using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    public class Connections
    {
        public DataContext bd = new DataContext(ConfigurationManager.ConnectionStrings["proischestwia"].ConnectionString);
        public DataContext getData()
        {
            return bd;
        }
    }
}
