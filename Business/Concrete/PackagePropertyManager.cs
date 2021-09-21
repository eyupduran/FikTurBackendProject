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
    public class PackagePropertyManager:IPackagePropertyService
    {
        private IPackagePropertyDal _packagePropertyDal;

        public PackagePropertyManager(IPackagePropertyDal packagePropertyDal)
        {
            _packagePropertyDal = packagePropertyDal;
        }

        public IResult Add(PackageProperty packageProperty)
        {
            this._packagePropertyDal.Add(packageProperty);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(PackageProperty packageProperty)
        {
            this._packagePropertyDal.Delete(packageProperty);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<PackageProperty>> GetAll()
        {
            return new SuccessDataResult<List<PackageProperty>>(_packagePropertyDal.GetList().ToList());
        }

        public DataResult<List<PackagePropertyDetailsDto>> GetAllPackagePropertyDetails()
        {
            return new SuccessDataResult<List<PackagePropertyDetailsDto>>(_packagePropertyDal.GetAllPackagePropertyDetails());
        }

        public DataResult<List<PackagePropertyDetailsDto>> GetAllPackagePropertyDetailsByPackageId(int id)
        {
            return new SuccessDataResult<List<PackagePropertyDetailsDto>>(_packagePropertyDal.GetAllPackagePropertyDetailsByPackageId(id));
        }

        public IDataResult<PackageProperty> GetById(int packagePropertyId)
        {
            return new SuccessDataResult<PackageProperty>(_packagePropertyDal.Get(p => p.Id == packagePropertyId));
        }

        public DataResult<PackagePropertyDetailsDto> GetOnePackagePropertyDetailsById(int id)
        {
            return new SuccessDataResult<PackagePropertyDetailsDto>(_packagePropertyDal.GetOnePackagePropertyDetailsById(id));
        }

        public IResult Update(PackageProperty packageProperty)
        {
            this._packagePropertyDal.Update(packageProperty);
            return new SuccessResult(Messages.Success);
        }
    }
}
