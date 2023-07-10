using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
       //uyguamarınızda ihtiyacı kullanak gerekir. niyet güdümlü ilerlemek gerekir. Ara yüzden başlayıp kodlamak gerekir. 
    }
}
