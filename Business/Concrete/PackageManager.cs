using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PackageManager:IPackageService
    {
        private IPackageDal _packageDal;

        public PackageManager(IPackageDal packageDal)
        {
            _packageDal = packageDal;
        }

        public IResult Add(Package package)
        {
            this._packageDal.Add(package);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(Package package)
        {
            this._packageDal.Delete(package);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<Package>> GetAll()
        {
            return new SuccessDataResult<List<Package>>(_packageDal.GetList().ToList());
        }

        public IResult Update(Package package)
        {
            this._packageDal.Update(package);
            return new SuccessResult(Messages.Success);
        }
    }
}
