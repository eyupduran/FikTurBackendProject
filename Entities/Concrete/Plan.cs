using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Plan:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PropertyId { get; set; }
        public string Description { get; set; }
    }
}
