﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PoldyCv
{
    class Baglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1DNGMBR\\MSSQL;Initial Catalog=PoldyCv;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
