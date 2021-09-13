using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlanDal : EfEntityRepositoryBase<Plan, FikTurContext>, IPlanDal
    {
        public List<PlanAndTourOrderDetailsDto> GetAllPlanAndTourOrderDetails()
        {
            using (FikTurContext context = new FikTurContext())
            {
                var result = from p in context.Plans
                             join to in context.TourOrders
                             on p.TourOrderId equals to.Id
                             select new PlanAndTourOrderDetailsDto
                             {
                                 PlanId = p.Id,
                                 PlanName = p.Name,
                                 TourOrderId = p.TourOrderId,
                                 DescriptionOfPlan = p.Description,
                                 ToCityId = to.ToCityId,
                                 FromCityId = to.FromCityId,
                                 StartDate = to.StartDate,
                                 FinishDate = to.FinishDate,
                                 DescriptionOfTourOrder = to.Description,
                                 NameOfTourOrder = to.Name
                             };
                return result.ToList();
            }

        }

        public List<PlanAndTourOrderDetailsDto> GetAllPlanAndTourOrderDetailsByTourId(int tourOrderId)
        {
             using (FikTurContext context = new FikTurContext())
            {
                var result = from p in context.Plans
                             join to in context.TourOrders
                             on p.TourOrderId equals to.Id
                             where tourOrderId == p.TourOrderId

                             select new PlanAndTourOrderDetailsDto
                             {
                                 PlanId = p.Id,
                                 PlanName=p.Name,
                                 TourOrderId=p.TourOrderId,
                                 DescriptionOfPlan=p.Description,
                                 ToCityId=to.ToCityId,
                                 FromCityId=to.FromCityId,
                                 StartDate=to.StartDate,
                                 FinishDate=to.FinishDate,
                                 DescriptionOfTourOrder= to.Description,
                                 NameOfTourOrder=to.Name
                             };
                return result.ToList();
            }
        }
    }
}

