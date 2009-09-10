using System;
using System.Collections.Generic;

public abstract class Player {

	private List<Card> hand;

	protected CardCounter counter = new CardCounter();

	public int getPlayerScore ()
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public abstract void makeMove (GameData game);

}
