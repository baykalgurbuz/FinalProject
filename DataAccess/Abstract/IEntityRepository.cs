using Entities.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{ 
    //class :referans tip olabilir anlamında
    //sistem suanda bir referans tip tutan değerlerle, IEntitiy den türemiş newlwnwbilen bir yapıyla çalışmaktadır .
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);//Tek data getirmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    
    }
}
