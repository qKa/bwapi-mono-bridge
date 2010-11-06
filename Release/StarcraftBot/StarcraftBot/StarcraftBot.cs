using System;
using BWAPI;
using System.ComponentModel;
using System.Collections.Generic;

namespace StarcraftBot
{
	public class StarcraftBot : BWAPI.IStarcraftBot
	{
		List<BW.Unit> myUnits;
		List<Unit> enemies;

		Terrain.Analyzer a;
		bool analysisDone = false;
		public void onStart()
		{
			Util.Logger.Instance.Log("Bot Started");
			Util.Logger.Instance.Log("Enabling User Input");
            bwapi.Broodwar.sendText("Mono StarcraftBot initialised");
			bwapi.Broodwar.enableFlag(1);
			
			a = new Terrain.Analyzer();
			a.Done += new EventHandler(a_Done);
			a.Run();

			myUnits = new List<BW.Unit>();
			enemies = new List<Unit>();
		}

		void a_Done(object sender, EventArgs e)
		{
			bwapi.Broodwar.printf("Terrain Analysis Complete");
			analysisDone = true;
		}

		public void onEnd(bool isWinner)
		{
			Util.Logger.Instance.Log("Game Over. I " + ((isWinner) ? "Won." : "Lost."));
		}

		public void onFrame()
		{
			foreach (var unit in myUnits)
			{
				if (!unit.HasTarget() && enemies.Count > 0)
				{
					unit.Attack(enemies[0]);
				}
				else if( analysisDone )
				{
					
				}
			}
		}

		public void onSendText(string text)
		{
			
		}

		public void onReceiveText(BWAPI.Player player, string text)
		{
			
		}

		public void onPlayerLeft(BWAPI.Player player)
		{
			
		}

		public void onNukeDetect(BWAPI.Position target)
		{
			
		}

		public void onUnitDiscover(BWAPI.Unit unit)
		{
			
		}

		public void onUnitEvade(BWAPI.Unit unit)
		{
			
		}

		public void onUnitShow(BWAPI.Unit unit)
		{
			if (unit.getPlayer() == bwapi.Broodwar.self())
			{
				enemies.Add(unit);
				bwapi.Broodwar.printf("Unit Shown: [" + unit.getType().getName() + "] at [" + unit.getPosition().xConst() + "," + unit.getPosition().yConst() + "]");
			}
		}

		public void onUnitHide(BWAPI.Unit unit)
		{
			if (unit.getPlayer() == bwapi.Broodwar.self())
			{
				enemies.Remove(unit);
				bwapi.Broodwar.printf("Unit Hidden: [" + unit.getType().getName() + "] at [" + unit.getPosition().xConst() + "," + unit.getPosition().yConst() + "]");
			}
		}

		public void onUnitCreate(BWAPI.Unit unit)
		{
			if (unit.getPlayer() != bwapi.Broodwar.self())
			{
				myUnits.Add(new BW.Unit(unit));
				bwapi.Broodwar.printf("Unit Created: [" + unit.getType().getName() + "] at [" + unit.getPosition().xConst() + "," + unit.getPosition().yConst() + "]");
			}
		}

		public void onUnitDestroy(BWAPI.Unit unit)
		{
			
		}

		public void onUnitMorph(BWAPI.Unit unit)
		{
			
		}

		public void onUnitRenegade(BWAPI.Unit unit)
		{
			
		}

		public void onSaveGame(string gameName)
		{
			
		}
	}
}
