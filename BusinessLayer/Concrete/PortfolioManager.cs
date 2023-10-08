using BusinessLayer.Abstract;
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
            throw new NotImplementedException();
        }

        public void TDelete(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public Portfolio TGetBtID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            throw new NotImplementedException();
        }
    }
}
