using GameQuiz2.Abstract;
using GameQuiz2.Business;
using GameQuiz2.Entities;

namespace GameQuiz2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            IUserService userManager = new UserManager(new UserValidationManager());
            IOfferService offerService = new OfferManager();
            ISellerService sellerManager = new SellerManager();

            User user1 = new User()
            {
                Name="Hasan",
                TcNo="123123"
            
            };
            
            userManager.UserAdd(user1);
            Games games = new Games() 
            { 
            GameName="csgo",
            Price=100
            };
            Offer offer = new Offer()
            {
                OfferDicount = 0.4f,
            };


            
            offerService.OfferDiscount(offer, games);



            sellerManager.Seller(user1,games);
        }
    }
}