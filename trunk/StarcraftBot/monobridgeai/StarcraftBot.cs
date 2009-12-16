using System;
using BWAPI;

namespace MonoBridgeAI {
	class StarcraftBotProxy {
		private MonoStarcraftBotBase realbot;
		
		public StarcraftBotProxy() {
			realbot = new StarcraftBot.MonoStarcraftBot();
		}
		public void onStart() {
			realbot.onStart();
		}

		public void onInit() {
			bridge.Broodwar.printf("MonoBridgeAI Proxy Class Initialised");
		}
		
		public void onEnd() {
			realbot.onEnd();
		}
		
		public void onFrame() {
			realbot.onFrame();
		}
		
		public Boolean onSendText(string text) {
			return realbot.onSendText(text);
		}
		
		public void onUnitCreate() {
			realbot.onUnitCreate(monobridgeutil.getLastUnitParam());
		}
		
		public void onUnitDestroy() {
			realbot.onUnitDestroy(monobridgeutil.getLastUnitParam());
		}
		public void onUnitMorph() {
			realbot.onUnitMorph(monobridgeutil.getLastUnitParam());
		}
		public void onUnitShow() {
			realbot.onUnitShow(monobridgeutil.getLastUnitParam());	
		}
		public void onUnitHide() {
			realbot.onUnitHide(monobridgeutil.getLastUnitParam());
		}
	
	}
}

