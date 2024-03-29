﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	public class Player
	{
		private Winner winner;
		private Choice choice;
		private int winCount;
		private int lossCount;
		private int drawCount;

		public Winner Winner
		{
			get
			{
				return winner;
			}
            set
            {
                winner = value;
            }
        }

		public Choice Choice
		{
			get
			{
				return choice;
			}
			set
			{
				choice = value;
			}
		}

		public int WinCount
		{
			get
			{
				return winCount;
            }
            set
            {
                winCount = value;
            }
        }

		public int LossCount
		{
			get
			{
				return lossCount;
            }
            set
            {
                lossCount = value;
            }
        }

		public int DrawCount
		{
			get
			{
				return drawCount;
            }
            set
            {
                drawCount = value;
            }
        }
		public Player()
		{
			winner = Winner.User;
		}

		public Player(Winner wnrWinner)
		{
			this.winner = wnrWinner;
		}

		public void OnWinnerAnnounced(Winner wnrNewWinner)
		{
            //Increment the correct counter based on the winner
			if (wnrNewWinner == Winner)
				winCount++;
			else if (wnrNewWinner == Winner.Draw)
				drawCount++;
			else
				lossCount++;
		}

		public override string ToString()
		{
            //Return a string representation of the player object
			return "Win count: " + WinCount + "\n" +
                "Draw count: " + DrawCount + "\n" +
                "Loss count: " + LossCount + "\n" +
				"Current Choice: " + choice;
		}
	}
}
