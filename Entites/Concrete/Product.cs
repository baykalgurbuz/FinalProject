using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    //Bir clasın default belirteci internaldır .
    //Diğer katmanlarda ulaşabilsin diye public kullandık 
    public class Product:IEntitiy
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
