using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLaba2
{
    class Util
    {
        private static DBConnector db;
        public static DBConnector DB
        {
            set { db = value; }
            get { return db; }
        }
    }
}
