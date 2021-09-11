using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IPackageService
    {
        IDataResult<List<Package>> GetAll();
        IResult Add(Package package);
        IResult Delete(Package package);
        IResult Update(Package package);
        IDataResult<Package> GetById(int packageId);

        IDataResult<List<Package>> getByPrice(decimal min, decimal max);
    }
}
