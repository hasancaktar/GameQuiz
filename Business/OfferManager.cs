using GameQuiz2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz2.Business
{
    internal class OfferManager : Abstract.IOfferService
    {
        public void OfferDelete(Offer offer, Games games)
        {
            throw new NotImplementedException();
        }

        public void OfferDiscount(Offer offer, Games games)
        {
            int totalOffer = (int)(games.Price * offer.OfferDicount);
                Console.WriteLine(games.GameName+ " oyununa yüzde " + totalOffer + " indirim yapıldı");
        }

        public Offer OfferUpdate(Games games)
        {
            throw new NotImplementedException();
        }
    }
}
