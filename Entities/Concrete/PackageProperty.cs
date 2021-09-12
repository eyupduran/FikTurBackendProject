using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PackageProperty:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int PackageId { get; set; }
    }
}
