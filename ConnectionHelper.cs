using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare
{
    public class ConnectionHelper
    {
        public static string MediCon
        {
            get
            {
                string dbPath = Path.Combine(Path.GetFullPath(@"..\..\"), "MediCareDB.mdf");
                return $@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename={dbPath};Initial Catalog=MediCareDB;Trusted_Connection=True";
            }


        }
    }
}
