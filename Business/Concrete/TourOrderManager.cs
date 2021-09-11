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
    public class TourOrderManager : ITourOrderService
    {
        private ITourOrderDal _tourOrderDal;
        public TourOrderManager(ITourOrderDal tourOrderDal)
        {
            _tourOrderDal = tourOrderDal;

        }
        public IResult Add(TourOrder tourOrder)
        {
            this._tourOrderDal.Add(tourOrder);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(TourOrder tourOrder)
        {
            this._tourOrderDal.Delete(tourOrder);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<TourOrder>> GetAll()
        {
            return new SuccessDataResult<List<TourOrder>>(_tourOrderDal.GetList().ToList());
        }

        public DataResult<List<AllTourOrderDetailsDto>> GetAllTourOrderDetailsById(int tourOrderId)
        {
            return new SuccessDataResult<List<AllTourOrderDetailsDto>>(_tourOrderDal.GetAllTourOrderDetailsById(tourOrderId));
        }

        public IDataResult<TourOrder> GetById(int id)
        {
            return new SuccessDataResult<TourOrder>(_tourOrderDal.Get(to=>to.Id==id));
        }

        public IResult Update(TourOrder tourOrder)
        {
            this._tourOrderDal.Update(tourOrder);
            return new SuccessResult(Messages.Success);
        }
    }
}
