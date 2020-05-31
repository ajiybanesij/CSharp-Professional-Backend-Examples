using DevFramework.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevFramework.Core.DataAccess
{
    //Temel IQueryable Repositorysi
    //ToList yapıldığında context kapanıyor. Kapanmadan  IQueryable operasyonlar yapılması için bu yapı oluşturuldu.
    public interface IQueryableRepository<T> where T:class,IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
