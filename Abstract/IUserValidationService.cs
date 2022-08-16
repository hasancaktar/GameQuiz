using GameQuiz2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz2.Abstract
{
    internal interface IUserValidationService
    {
        bool Validation(User user);
    }
}
