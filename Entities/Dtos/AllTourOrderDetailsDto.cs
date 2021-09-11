using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class AllTourOrderDetailsDto:IDto
    {
        public int Id { get; set; }
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public string FromCityName { get; set; }
        public string ToCityName { get; set; }
    }
}
