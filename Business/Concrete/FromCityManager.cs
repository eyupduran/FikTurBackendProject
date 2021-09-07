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
    public class FromCityManager : IFromCityService
    {
        private IFromCityDal _cityDal;

        public FromCityManager(IFromCityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(FromCity city)
        {
            this._cityDal.Add(city);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(FromCity city)
        {
            this._cityDal.Delete(city);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<FromCity>> GetAll()
        {
            return new SuccessDataResult<List<FromCity>>(_cityDal.GetList().ToList());
        }

        public IResult Update(FromCity city)
        {
            this._cityDal.Update(city);
            return new SuccessResult(Messages.Success);
        }
    }
}
