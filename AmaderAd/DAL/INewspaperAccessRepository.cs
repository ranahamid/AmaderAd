using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmaderAd.DAL
{
    public interface INewspaperAccessRepository<TEntity, in TPrimaryKey> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TPrimaryKey id);
        void Post(TEntity entity);
        void Put(TPrimaryKey id, TEntity entity);
        void Delete(TPrimaryKey id);  
        
        //extra


    }
}