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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetList();
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDal.Insert(t);    
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);    
        }

        public Portfolio TGetBtID(int id)
        {
            return _portfolioDal.GetById(id);   
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);    
        }
    }
}
