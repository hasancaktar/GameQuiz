using GameQuiz2.Abstract;
using GameQuiz2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz2.Business
{
    internal class UserManager : Abstract.IUserService
    {
        private IUserValidationService _userValidationService;
        public UserManager(IUserValidationService userValidationService)
        {
             _userValidationService = userValidationService;
        }

        public void UserAdd(User user)
        {
            if (_userValidationService.Validation(user))
            {
                Console.WriteLine("Kullanıcı Eklendi"+ user.Name);
            }
            else
                Console.WriteLine("Kullanıcı Eklenemedi!");
        }

        public void UserDelete()
        {
            throw new NotImplementedException();
        }

        public void UserUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
