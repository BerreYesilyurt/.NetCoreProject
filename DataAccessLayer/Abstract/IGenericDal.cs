﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class /*T değeri bir Class'a ait bütün özellikleri alabilir*/
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);   
        List<T> GetList();
        T GetById(int id);
    }
}
