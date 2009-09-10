using System;
using System.Collections.Generic;

public class AbstractCard {
	public List<Card> cards {get; private set;}

	public int getValue ()
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

