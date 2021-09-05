using Core.Utilities.Results;
using Entities.Concrete;
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

    }
}
