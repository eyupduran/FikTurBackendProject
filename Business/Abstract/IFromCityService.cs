using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFromCityService
    {
        IDataResult<List<FromCity>> GetAll();
        IResult Add(FromCity city);
        IResult Delete(FromCity city);
        IResult Update(FromCity city);
    }
}
