using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG1._0
{
    public class BDConnection
    {
        public static string ConnectionPath
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=C:\Users\giovanna.ctonetto\source\repos\RPG1.0\RPG1.0\BDRPG.mdf;
                Integrated Security=True;Connect Timeout=15";

            }

        }
    }
}
