using GameQuiz2.Abstract;
using GameQuiz2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz2.Business
{
    internal class UserValidationManager : IUserValidationService
    {
        bool IUserValidationService.Validation(User user)
        {
            if (user.Name == "Hasan" && user.TcNo == "123123")
            {
                return true;
            }
            return false;
        }
    }
}
