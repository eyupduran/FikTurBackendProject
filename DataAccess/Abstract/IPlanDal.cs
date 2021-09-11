using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPlanDal : IEntityRepository<Plan>
    {
       List<PlanAndTourOrderDetailDto> GetAllPlanAndTourOrderDetailsByTourId(int tourId);
    }
}
