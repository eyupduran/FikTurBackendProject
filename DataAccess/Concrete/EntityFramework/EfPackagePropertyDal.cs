using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPackagePropertyDal : EfEntityRepositoryBase<PackageProperty, FikTurContext>, IPackagePropertyDal
    {
        public List<PackagePropertyDetailsDto> GetAllPackagePropertyDetails()
        {
            using (FikTurContext context = new FikTurContext())
            {
                var result = from pp in context.PackageProperties
                             join p in context.Packages on pp.PackageId equals p.Id 
                             select new PackagePropertyDetailsDto
                             {
                                 Id = pp.Id,
                                 Description = pp.Description,
                                 PackageId = pp.PackageId,
                                 DetailOfPackage = p.Detail,
                                 PriceOfPackage = p.Price
                             };
                return result.ToList();
            }
        }

        public PackagePropertyDetailsDto GetOnePackagePropertyDetailsById(int id)
        {
            using (FikTurContext context=new FikTurContext())
            {
                var result = from pp in context.PackageProperties
                             join p in context.Packages on pp.PackageId equals p.Id
                             where id == pp.Id
                             select new PackagePropertyDetailsDto
                             {
                                 Id = pp.Id,
                                 Description = pp.Description,
                                 PackageId = pp.PackageId,
                                 DetailOfPackage = p.Detail,
                                 PriceOfPackage = p.Price
                             };
                return result.SingleOrDefault();
            }
        }
    }
}
