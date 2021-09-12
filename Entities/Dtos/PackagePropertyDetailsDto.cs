using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class PackagePropertyDetailsDto:IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int PackageId { get; set; }
        public string DetailOfPackage { get; set; }
        public int PriceOfPackage { get; set; }
    }
}
