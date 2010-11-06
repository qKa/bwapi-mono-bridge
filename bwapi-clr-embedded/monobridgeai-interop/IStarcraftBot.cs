/*
 * Created by SharpDevelop.
 * User: David
 * Date: 14/12/2009
 * Time: 7:30 PM
 * 
 */
using System;

namespace BWAPI
{
	/// <summary>
	/// Base Class for Mono Starcraft Bots
	/// </summary>
	public interface IStarcraftBot
	{
		void onStart();
		void onEnd(bool isWinner);
		void onFrame();
		void onSendText(string text);
		void onReceiveText(BWAPI.Player player, string text);
		void onPlayerLeft(BWAPI.Player player);
		void onNukeDetect(BWAPI.Position target);
		void onUnitDiscover(BWAPI.Unit unit);
		void onUnitEvade(BWAPI.Unit unit);
		void onUnitShow(BWAPI.Unit unit);
		void onUnitHide(BWAPI.Unit unit);
		void onUnitCreate(BWAPI.Unit unit);
		void onUnitDestroy(BWAPI.Unit unit);
		void onUnitMorph(BWAPI.Unit unit);
		void onUnitRenegade(BWAPI.Unit unit);
		void onSaveGame(string gameName);
	}
}