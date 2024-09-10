using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging;
using Npgsql;
using PresOrm.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace PresOrm.Data
{
    public class ContextPresOrm : DbContext
    {
        public NpgsqlDataSource NpgsqlDataSource { get; }
        public bool IsLazyOn { get; }

        public DbSet<EntityCar> Cars { get; set; }

        public ContextPresOrm(NpgsqlDataSource npgsqlDataSource, bool isLazyOn)
        {
            NpgsqlDataSource = npgsqlDataSource;
            IsLazyOn = isLazyOn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(NpgsqlDataSource);
            if (IsLazyOn) options.UseLazyLoadingProxies();
            options.LogTo(e => { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(e); }, LogLevel.Information).EnableSensitiveDataLogging();
        }




    }

}
