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
			int count =0;	
			int eqcount =0;
			foreach (Unit u in us)  {
				if (u.getPlayer() == bridge.Broodwar.self()) {
					count++;	
				}
				if (u.getPlayer().Equals(bridge.Broodwar.self())) {
					eqcount++;	
				}
				
				
			}
			bridge.Broodwar.printf("Player unit count =  "+ count.ToString()+" equals() count = "+eqcount.ToString());
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