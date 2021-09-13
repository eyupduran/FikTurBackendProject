using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITourOrderService
    {
        IDataResult<List<TourOrder>> GetAll();
        IResult Add(TourOrder tourOrder);
        IResult Delete(TourOrder tourOrder);
        IResult Update(TourOrder tourOrder);
        IDataResult<TourOrder> GetById(int id);
        DataResult<TourOrderDetailsDto>GetOneTourOrderDetailsById(int tourOrderId);

    }
}
