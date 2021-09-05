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
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            this._cityDal.Add(city);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(City city)
        {
            this._cityDal.Delete(city);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetList().ToList());
        }

        public IResult Update(City city)
        {
            this._cityDal.Update(city);
            return new SuccessResult(Messages.Success);
        }
    }
}
