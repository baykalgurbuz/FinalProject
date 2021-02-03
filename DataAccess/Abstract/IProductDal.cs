using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal//İnterface 'in kendisi public değildir bu yüzden public key ini eklememiz lazım .Metodlara eklemememizin sebebi ise doğustan public olmaları 
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAllByCategory(int categoryId);

    }
}
