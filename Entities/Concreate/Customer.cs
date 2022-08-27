using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public  class Customer:IEntity
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ComponyName { get; set; }
        public string City { get; set; }
    }
}
