using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace PLC.Instrument.EntityFramework.Repositories
{
    public abstract class InstrumentRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<InstrumentDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected InstrumentRepositoryBase(IDbContextProvider<InstrumentDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class InstrumentRepositoryBase<TEntity> : InstrumentRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected InstrumentRepositoryBase(IDbContextProvider<InstrumentDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
