using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName{ get; set; }
    }
}
