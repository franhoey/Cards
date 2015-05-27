using System;
using System.Linq;
using Cards.Features;

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
			return new Card(
				_cardSet.Features.Select(FeatureFactory.BuildFeature));
	    }
    }
}
