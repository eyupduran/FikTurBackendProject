using Core.DataAccess.EntityFramework;
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
    public class EfTourOrderDal : EfEntityRepositoryBase<TourOrder, FikTurContext>, ITourOrderDal
    {
        public List<TourOrderDetailsDto> GetAllTourOrderDetailsById(int id)
        {
            using (FikTurContext context=new FikTurContext())
            {
                var result = from to in context.TourOrders
                             join fc in context.FromCities on to.FromCityId equals fc.Id
                             join tc in context.ToCities on to.ToCityId equals tc.Id
                             where id == to.Id
                             select new TourOrderDetailsDto
                             {
                                 Id = to.Id,
                                 FromCityId = to.FromCityId,
                                 ToCityId = to.ToCityId,
                                 StartDate = to.StartDate,
                                 FinishDate = to.FinishDate,
                                 Description = to.Description,
                                 Name = to.Name,
                                 FromCityName = fc.Name,
                                 ToCityName = tc.Name

                             };
                return result.ToList();

            }
        }
    }
}
