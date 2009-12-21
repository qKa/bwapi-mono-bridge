/*
 * Created by SharpDevelop.
 * User: David
 * Date: 14/12/2009
 * Time: 6:30 PM
 * 
 * This is where you code your bot!
 * 
 * 
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
			bridge.Broodwar.printf("Hello from a bot implemented in c#");
			bridge.Broodwar.enableFlag(1);
			
			//count units
			UnitSet us = bridge.Broodwar.getAllUnits();
			int count = 0;	
			int immobilised = 0;
			foreach (Unit u in us)  {
				if (u.getPlayer() == bridge.Broodwar.self()) {
					count++;	
				}
				//call our example extension to the unit class. see monobridgeai-interop user-classes\unit-extended.cs 
				if (u.isImmobilised()) {
					immobilised++;  
				}
			}
			bridge.Broodwar.printf("Player unit count =  "+ count.ToString()+". "+immobilised.ToString() +" are immobilised");
		}
		
		public override Boolean onSendText(string text)
		{
			//flash a circle on the screen for one frame
			if (text == "drawcircle") {
				bridge.Broodwar.drawCircle((int) CoordinateType.Screen,100,100,100,bridge.Blue,true);
			}
			return true;
		}
	}
}