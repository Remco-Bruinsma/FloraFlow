using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlora.Class
{
    public class Connectionstring
    {
        public static string Phpmyadmin()
        {
            string cs = "Datasource = 127.0.0.1; port = 3306; username = root; password =; database = floraflow";
            return cs;
        }
        public static string floraflowserver()
        {
            string cs = "Datasource=192.168.160.124;port=3306;username=AppUser;password=@ppUs3r123;database= floraflow";
            return cs;
        }
        public static string onlineHeraPhpmyadmin()
        {
            string cs = "Server = studmysql01.fhict.local; Uid = dbi351916; Database = dbi351916; Pwd = >8>8>8";
            return cs;
        }
        public static string InUse()
        {
            string cs = Phpmyadmin();
            return cs;
        }
    }
}
