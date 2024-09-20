using Microsoft.EntityFrameworkCore;

namespace PresOrm.Data.Repositories
{
    public abstract class AGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public AGenericRepository(DbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet/*.AsNoTracking()*/;
        }

        public IQueryable<TEntity> GetAllAsNoTracking()
        {
            return DbSet.AsNoTracking();
        }

        public TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Create(TEntity entity)
        {
            DbSet.Add(entity);
            Db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
            Db.SaveChanges();
        }

        public void DeleteById(object id)
        {
            var entity = GetById(id);
            Delete(entity);
        }

        public void Delete(TEntity entityToDelete)
        {
            if (Db.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
            Db.SaveChanges();
        }
    }
}
