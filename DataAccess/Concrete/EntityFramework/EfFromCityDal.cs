using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFromCityDal : EfEntityRepositoryBase<FromCity, FikTurContext>, IFromCityDal
    {
        public DataResult<FromCity> GetByCityName(string name)
        {
            //using (var context = new FikTurContext()) {
            //    var result=from fc in context.FromCities
            //               where name
            //}
            return null;
        }
    }
}
