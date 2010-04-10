/*
 * This is the .net class that is called from the C++ code. It will load your bot file from the
 * StarcraftBot project (see monostarcraftbot.cs). Do not modify this unless you really need to as
 * the C++ code depends on the namespace, classname and some method names in this assembly.
 */

using System;
using BWAPI;

using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace MonoBridgeAI {
	class StarcraftBotProxy {
		private MonoStarcraftBotBase realbot;
		
		public delegate void Callback ();

		private Callback onStartCallback;
		private Callback onEndCallback;
		private Callback onFrameCallback;
		private Callback onInitCallback;
		private Callback onUnitCreateCallback;
		private Callback onUnitDestroyCallback;
		private Callback onUnitMorphCallback;
		private	Callback onUnitShowCallback;
		private Callback onUnitHideCallback;
		
		[DllImport("__Internal")]
		extern static  void RegisterCallbacks(
			Callback cbonStart,
			Callback cbonEnd,
			Callback cbonFrame,
			Callback cbonInit,
			Callback cbonUnitCreate,
			Callback cbonUnitDestroy,
			Callback cbonUnitMorph,
			Callback cbonUnitShow,
			Callback cbonUnitHide);
		
		public StarcraftBotProxy() {
            bridgePINVOKEProxy.connectProxy();
            try
            {
                RemotingConfiguration.Configure("monobridgeai.dll.config",false);
            }
            catch (Exception e)
            {
                bridge.Broodwar.printf("Error loading remote config." + e.Message);
            }
            realbot = new StarcraftBot.MonoStarcraftBot();
			
			RegisterNativeCallbacks();
		}

		void RegisterNativeCallbacks()
		{
			onStartCallback = new Callback(onStart);
			onEndCallback = new Callback(onEnd);
			onFrameCallback = new Callback(onFrame);
			onInitCallback = new Callback(onInit);
			onUnitCreateCallback = new Callback(onUnitCreate);
			onUnitDestroyCallback = new Callback(onUnitDestroy);
			onUnitMorphCallback = new Callback(onUnitMorph);
			onUnitShowCallback = new Callback(onUnitShow);
			onUnitHideCallback = new Callback(onUnitHide);
			RegisterCallbacks(onStartCallback, onEndCallback, onFrameCallback, onInitCallback, onUnitCreateCallback, onUnitDestroyCallback, onUnitMorphCallback, onUnitShowCallback, onUnitHideCallback);
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

