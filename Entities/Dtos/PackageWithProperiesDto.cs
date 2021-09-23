using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class PackageWithProperiesDto
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public int Price { get; set; }
        public List<PackageProperty> PackageProperties { get; set; }
    }
}
