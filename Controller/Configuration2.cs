using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows_PDV.Database;

namespace Windows_PDV {
    public class Configuration2 {

        public static DBConnection Connection { get; set; }

        public static void InitializeDatabase() {
            Connection = new DBConnection();
            Connection.Server = "127.0.0.1";
            Connection.User = "root";
            Connection.Password = "dwHandle";
            Connection.Port = 3306;
            Connection.Database = "pdv";
        }
        
    }
}
