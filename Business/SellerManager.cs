using GameQuiz2.Abstract;
using GameQuiz2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz2.Business
{
    internal class SellerManager : ISellerService
    {
        public void Seller(User user, Games games)
        {
            Console.WriteLine(games.GameName +" oyunu"+ user.Name+ " kullanıcısına satıldı");
        }
    }
}
