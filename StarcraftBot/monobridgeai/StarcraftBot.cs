using System;

namespace MonoBridgeAI {
	class StarcraftBotProxy {
		private MonoStarcraftBotBase realbot;
		
		public StarcraftBotProxy() {
			realbot = new StarcraftBot.MonoStarcraftBot();
		}
		public void onStart() {
			realbot.onStart();
		}
	/*
	 * BridgeAIModule::initMethod = MethodFromKlass(":Init()",klass);
	BridgeAIModule::startMethod = MethodFromKlass(":onStart()",klass);
	BridgeAIModule::endMethod = MethodFromKlass(":onEnd()",klass);
	BridgeAIModule::frameMethod = MethodFromKlass(":onFrame()",klass);
	BridgeAIModule::sendTextMethod = MethodFromKlass(":onSendText(string)",klass);
	BridgeAIModule::unitCreateMethod = MethodFromKlass(":onUnitCreate()",klass);
	BridgeAIModule::unitDestroyMethod = MethodFromKlass(":onUnitDestroy()",klass);
	BridgeAIModule::unitMorphMethod = MethodFromKlass(":onUnitMorph()",klass);
	BridgeAIModule::unitShowMethod = MethodFromKlass(":onUnitShow()",klass);
	BridgeAIModule::unitHideMethod = MethodFromKlass(":onUnitHide()",klass);
	*/
		public void onInit() {
			bridge.Broodwar.printf("MonoBridgeAI Proxy Class Initialised");
			//load our ai class from a dll but until then
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

