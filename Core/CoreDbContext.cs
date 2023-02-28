using Core.Model;
using System;
using System.Data.Entity;

namespace Core
{
    public class CoreDbContext : DbContext, IDbContext
    {

        public CoreDbContext(): base("name=DbConnectionString")
        {

        }
      
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
