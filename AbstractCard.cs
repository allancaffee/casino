using System;
using System.Collections.Generic;

public class AbstractCard {
	public AbstractCard(Card c) {
		cards = new List<Card>();
		cards.Add (c);
	}
	private AbstractCard() {}
	public List<Card> cards {get; private set;}

	public Card.Face getValue ()
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public bool canAddTo (AbstractCard card)
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public void addTo (AbstractCard other)
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public bool canPairWith (AbstractCard other)
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public void pairWith (AbstractCard card)
	{
		throw new System.Exception ("Not implemented yet!");
	}

}

