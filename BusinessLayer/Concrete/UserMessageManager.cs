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
    public class UserMessageManager:IUserMessageService
    {
        IUserMessageDal _usermessageDal;

        public UserMessageManager(IUserMessageDal usermessageDal)
        {
            _usermessageDal = usermessageDal;
        }

        public List<UserMessage> GetList()
        {
            return _usermessageDal.GetList();   
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
            return _usermessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetBtID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
