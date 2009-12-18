/*
 * Created by SharpDevelop.
 * User: David
 * Date: 14/12/2009
 * Time: 6:30 PM
 */
using System;
using System.Collections.Generic;
using BWAPI;

namespace StarcraftBot
{
	/// <summary>
	/// Bot AI Class. Override the methods from MonoStarcraftBotBase as needed.
	/// </summary>
	public class MonoStarcraftBot: MonoStarcraftBotBase
	{
		public override void onStart() {
			bridge.Broodwar.printf("Hello from actual bot implementation");
			bridge.Broodwar.enableFlag(1);
			
			//list units.
			UnitSet us = bridge.Broodwar.getAllUnits();
			foreach (Unit u in us)  {
				bridge.Broodwar.printf(u.getType().getName());
			}
		}
		
		public override Boolean onSendText(string text)
		{
			if (text == "drawbox") {
				bridge.Broodwar.drawCircle((int) CoordinateType.Screen,100,100,100,bridge.Blue,true);
			}
			return true;
		}
	}
}