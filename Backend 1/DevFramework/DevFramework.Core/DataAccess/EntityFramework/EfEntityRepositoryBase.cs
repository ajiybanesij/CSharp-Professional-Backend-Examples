using DevFramework.Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase <TEntity,TContex> : IEntityRepository<TEntity>:
        where TEntity:class,IEntity,new()
        where TContex:DbContext,new()
    {
    }
}
