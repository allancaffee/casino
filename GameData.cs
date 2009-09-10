using System;
using System.Collections.Generic;

public class GameData {
	private List<AbstractCard> table;
	private List<Card> deck;

	protected List<Player> players;

	public bool isTableEmpty ()
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public List<AbstractCard> getTable ()
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public void trailCard (Card c)
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public List<AbstractCard> captureWithCard (Card c)
	{
		throw new System.Exception ("Not implemented yet!");
	}
}
