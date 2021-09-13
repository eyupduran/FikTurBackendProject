using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
   public class PlanManager:IPlanService
    {
        private IPlanDal _plandal;

        public PlanManager(IPlanDal plandal)
        {
            _plandal = plandal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Plan plan)
        {
            this._plandal.Add(plan);
            return new SuccessResult(Messages.Success);
        }

        public IResult Delete(Plan plan)
        {
            this._plandal.Delete(plan);
            return new SuccessResult(Messages.Success);
        }

        public IDataResult<List<Plan>> GetAll()
        {
            return new SuccessDataResult<List<Plan>>(_plandal.GetList().ToList());
        }

        public DataResult<List<PlanAndTourOrderDetailsDto>> GetAllPlanAndTourOrderDetails()
        {
            return new SuccessDataResult<List<PlanAndTourOrderDetailsDto>>(_plandal.GetAllPlanAndTourOrderDetails());
        }

        public DataResult<List<PlanAndTourOrderDetailsDto>> GetAllPlanAndTourOrderDetailsByTourId(int tourId)
        {
            return new SuccessDataResult<List<PlanAndTourOrderDetailsDto>>(_plandal.GetAllPlanAndTourOrderDetailsByTourId(tourId));
        }

        public IDataResult<Plan> GetById(int id)
        {
            return new SuccessDataResult<Plan>(_plandal.Get(p=>p.Id==id)) ;
        }


        public IResult Update(Plan plan)
        {
            this._plandal.Update(plan);
            return new SuccessResult(Messages.Success);
        }
    }
}
