using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Package:IEntity
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public int Price { get; set; }
    }
}
