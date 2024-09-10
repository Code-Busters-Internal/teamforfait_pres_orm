using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresOrm.Data.Services
{
    public class ServiceOldSchool
    {
        public void ResetDB()
        {
            var con = new NpgsqlConnection(connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=pres_orm;");
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Delete FROM public.\"Brand\";";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Delete FROM public.\"Car\";";
            cmd.ExecuteNonQuery();
        }
    }
}
