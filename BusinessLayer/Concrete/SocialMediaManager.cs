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
    public class SocialMediaManager:ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public List<SocialMedia> GetList()
        {
            return _socialMediaDal.GetList();   
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDal.Insert(t);  
        }

        public void TDelete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);  
        }

        public SocialMedia TGetBtID(int id)
        {
            return _socialMediaDal.GetById(id); 
        }

        public List<SocialMedia> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);  
        }
    }
}
