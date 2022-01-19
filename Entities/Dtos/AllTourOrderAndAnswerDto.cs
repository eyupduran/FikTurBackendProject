using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AllTourOrderAndAnswerDto
    {

        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int TourOrderId { get; set; }
        public string DescriptionOfPlan { get; set; }
        public int ToCityId { get; set; }

        public string ToCityName { get; set; }
        public int FromCityId { get; set; }
        public string FromCityName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string DescriptionOfTourOrder { get; set; }
        public string NameOfTourOrder { get; set; }
    }
}
