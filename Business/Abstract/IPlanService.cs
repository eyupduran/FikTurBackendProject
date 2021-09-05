using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPlanService
    {
        IDataResult<List<Plan>> GetAll();
        IResult Add(Plan plan);
        IResult Delete(Plan plan);
        IResult Update(Plan plan);
    }
}
