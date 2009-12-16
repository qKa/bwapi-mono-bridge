/*
 * Created by SharpDevelop.
 * User: David
 * Date: 14/12/2009
 * Time: 7:30 PM
 * 
 */
using System;


	/// <summary>
	/// Base Class for Mono Starcraft Bots
	/// </summary>
	public class MonoStarcraftBotBase
	{
		public MonoStarcraftBotBase()
		{
		}
		
		public virtual void onStart() {
			
		}
				
		public virtual void onEnd() {
			
		}
		
		public virtual void onFrame() {
			
		}
		
		public virtual Boolean onSendText(string text) {
			return true;
		}
		
		public virtual void onUnitCreate(BWAPI.Unit unit) {
			
		}
		
		public virtual void onUnitDestroy(BWAPI.Unit unit) {
			
		}
		public virtual void onUnitMorph(BWAPI.Unit unit) {
			
		}
		public virtual void onUnitShow(BWAPI.Unit unit) {
			
		}
		public virtual void onUnitHide(BWAPI.Unit unit) {
			
		}
		
		
	}

