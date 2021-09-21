using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IPackagePropertyService
    {

        IDataResult<List<PackageProperty>> GetAll();
        IResult Add(PackageProperty packageProperty);
        IResult Delete(PackageProperty packageProperty);
        IResult Update(PackageProperty packageProperty);
        IDataResult<PackageProperty> GetById(int packagePropertyId);
        DataResult<PackagePropertyDetailsDto> GetOnePackagePropertyDetailsById(int id);
        DataResult<List<PackagePropertyDetailsDto>> GetAllPackagePropertyDetails();
        DataResult<List<PackagePropertyDetailsDto>> GetAllPackagePropertyDetailsByPackageId(int id);
    }
}
