using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IToCityService
    {
        IDataResult<List<ToCity>> GetAll();
        IResult Add(ToCity city);
        IResult Delete(ToCity city);
        IResult Update(ToCity city);

        IDataResult<ToCity> GetById(int id);
    }
}
