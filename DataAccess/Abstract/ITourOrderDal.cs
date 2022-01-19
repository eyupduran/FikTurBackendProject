using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITourOrderDal:IEntityRepository<TourOrder>
    {
        TourOrderDetailsDto GetOneTourOrderDetailsById(int id);

        List<TourOrderDetailsDto> GetAllTourOrderDetails();

        List<AllTourOrderAndAnswerDto> AllTourOrderAndAnswerByUserId(int userId);

    }
}
