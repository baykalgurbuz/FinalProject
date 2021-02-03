using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstraact
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
