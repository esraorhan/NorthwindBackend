using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // artık IEntityRepository içinde yer alan Crud işlemlerinin hepsi var anlamına geliyor. 
    }
}
