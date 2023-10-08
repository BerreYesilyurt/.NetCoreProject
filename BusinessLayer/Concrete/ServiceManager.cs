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
    public class ServiceManager:IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList(); // Business katmanında, IService'lar ieçrisinde sadece metot imzaları tanımlanmıştır. Bu imzaların içini doldurmak Manager katmanında yapılmaktadır.
            //Manager katmanında içlerini doldurabilmek için ise, DataAccess Layer katmanından yardım alınmalıdır. Bu yüzden IServiceDal oluşturulda ve bunu kullanarak metotlara erişim sağlandı.
        }

        public void TAdd(Service t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Service TGetBtID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
