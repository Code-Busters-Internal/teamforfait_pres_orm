using Microsoft.EntityFrameworkCore.Design;
using Npgsql;

namespace PresOrm.Data
{
    public class FactoryDatabaseContext: IDesignTimeDbContextFactory<ContextPresOrm>
    {

        public ContextPresOrm CreateDbContext(string[] args)
        {
            
            var connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=pres_orm;";

            return new ContextPresOrm(new NpgsqlDataSourceBuilder(connectionString).Build(), args!=null);

        }
    }
}
