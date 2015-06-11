using System;
using System.Linq;
using Cards.Cards.CardSets;
using Cards.Cards.CardSets.Random;

namespace Cards.Cards
{
    public class CardSelector
    {
		private readonly ICardSet _cardSet;

	    public CardSelector(ICardSet cardSet)
	    {
			if(cardSet == null)
				throw new ArgumentNullException("cardSet");

			_cardSet = cardSet;
	    }

	    public Card GetCard()
	    {
			return _cardSet.GetCard();
	    }
    }
}
