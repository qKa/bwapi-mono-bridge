/*
 * Created by SharpDevelop.
 * User: David
 * Date: 14/12/2009
 * Time: 6:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using BWAPI;

namespace StarcraftBot
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class MonoStarcraftBot: MonoStarcraftBotBase
	{
		public override void onStart() {
			bridge.Broodwar.printf("Hello from actual bot implementation");
			bridge.Broodwar.enableFlag(1);
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