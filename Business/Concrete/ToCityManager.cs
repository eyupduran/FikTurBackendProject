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
   public class ToCityManager:IToCityService
    {
        private IToCityDal _cityDal;

        public ToCityManager(IToCityDal toCityDal)
        {
            _cityDal = toCityDal;
        }

        public IResult Add(ToCity city)
        {
            this._cityDal.Add(city);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(ToCity city)
        {
            this._cityDal.Delete(city);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<ToCity>> GetAll()
        {
            return new SuccessDataResult<List<ToCity>>(_cityDal.GetList().ToList());
        }

        public IDataResult<ToCity> GetById(int id)
        {
            return new SuccessDataResult<ToCity>(_cityDal.Get(c=>c.Id==id));
        }

        public IResult Update(ToCity city)
        {
            this._cityDal.Update(city);
            return new SuccessResult(Messages.Success);
        }
    }
}
