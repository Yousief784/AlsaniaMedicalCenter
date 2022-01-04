using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alsaina
{
    public class Connection
    {
        public string database()
        {
            string conn = @"Data source = DESKTOP-D0S94ST\SQL2019; Initial Catalog = AlsaniaMedicalCenter; Integrated security = true;";
            return conn;
        }
        public string connectToMasterDatabase()
        {
            string conn = @"Data source = DESKTOP-D0S94ST\SQL2019;Initial Catalog=master;Integrated security= true;";
            return conn;
        }
    }
}


