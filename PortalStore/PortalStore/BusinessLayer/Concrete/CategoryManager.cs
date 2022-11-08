﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abscract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
           _categoryDal = categoryDal;
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDElete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetBYID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
