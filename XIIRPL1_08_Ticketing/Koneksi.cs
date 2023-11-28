using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL1_08_Ticketing
{
    internal class Koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection(
            "Server=127.0.0.1;Port=5432;Database=db_ticket_xii_rpl_1_8;" +
            "User Id=postgres;Password=admin;");
    }
}
