using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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

        public IDataResult<List<PackageWithProperiesDto>> GetAllPackagePropertyDetails()
        {
            return new SuccessDataResult<List<PackageWithProperiesDto>>(_packageDal.GetAllPackagePropertyDetails());
        }

        public IDataResult<Package> GetById(int packageId)
        {
            return new SuccessDataResult<Package>(_packageDal.Get(p=>p.Id==packageId));
        }

        public IDataResult<List<Package>> getByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Package>>(_packageDal.GetList(p => p.Price >= min && p.Price <= max).ToList());
        }

        public IResult Update(Package package)
        {
            this._packageDal.Update(package);
            return new SuccessResult(Messages.Success);
        }
    }
}
