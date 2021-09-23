using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfPackageDal:EfEntityRepositoryBase<Package, FikTurContext>, IPackageDal
    {
        public List<PackageWithProperiesDto> GetAllPackagePropertyDetails()
        {
            using (FikTurContext context = new FikTurContext())
            {
                var result = from p in context.Packages
                             select new PackageWithProperiesDto
                             {
                                 Id = p.Id,
                                 Price=p.Price,
                                 Detail=p.Detail,
                                 PackageProperties= GetAllPropertiesByPackageId(p.Id)
                             };
                return result.ToList();
            }
        }

        private List<PackageProperty> GetAllPropertiesByPackageId(int packageId)
        {
            using (FikTurContext context = new FikTurContext())
            {
                var result = from pp in context.PackageProperties
                             where pp.PackageId==packageId
                             select new PackageProperty
                             {
                                 Id = pp.Id,
                                 Description=pp.Description,
                                 PackageId=pp.PackageId
                             };
                return result.ToList();
            }
        }


    }
}
