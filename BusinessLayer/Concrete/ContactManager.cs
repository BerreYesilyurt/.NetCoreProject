﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetBtID(int id)
        {
            return _contactDal.GetById(id); 
        }

        public List<Contact> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);  
        }
    }
}
