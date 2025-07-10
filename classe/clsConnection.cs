using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ChambreHotel.classe
{
    internal class clsConnection
    {
        public static string chemin = "data source=SAGE-TECH\\SQLEXPRESS;initial catalog=Hotel_db;persist security info=true;Integrated Security=SSPI;encrypt=false";

        public void sage()
        {
            int a = 0;
            for(int i = 0; i < 10; i++)
            {
                a += i;
            }
        }
    }

}
