/*
 * This is the .net class that is called from the C++ code. It will load your bot file from the
 * StarcraftBot project (see monostarcraftbot.cs). Do not modify this unless you really need to as
 * the C++ code depends on the namespace, classname and some method names in this assembly.
 */

using System;
using BWAPI;
using log4net;
using log4net.Config;
using log4net.Layout;
using log4net.Appender;
using log4net.Repository;

using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace MonoBridgeAI {
	class StarcraftBotProxy {
		private AIProxy remotebot;
        public static ILog botlog;


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
            bridge.Broodwar.printf("Local Proxy Connected");
         
            try
            {
                SetupLog();
            }
            catch (Exception e)
            {
                bridge.Broodwar.printf(e.Message);
            }

           
            try
            {
                RemotingConfiguration.Configure("bwapi-data\\AI\\bot\\monobridgeai.dll.config",false);
            }
            catch (Exception e)
            {
                bridge.Broodwar.printf("Error loading remote config." + e.Message);
            }
            
            remotebot = null;
            bridge.Broodwar.printf("Connecting to Remote AI..");
            
            for (int i = 0; i < 1; i++)
            {
                try
                {
                    remotebot = new BWAPI.AIProxy();
                    bridge.Broodwar.printf("Connect Success:"+RemotingServices.IsTransparentProxy(remotebot));
                    break;
                }
                catch (Exception e)
                {
                   bridge.Broodwar.printf("Connect failed. Starting Attempt "+i+". Connecting..");
                }
            }
         
          //  remotebot = null;
			RegisterNativeCallbacks();
		}

        private void SetupLog()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream xmlStream = asm.GetManifestResourceStream("monobridgeai.logconfig.xml");

            XmlConfigurator.Configure(xmlStream);
            botlog = LogManager.GetLogger("monobotbase");
            botlog.Debug("Bot Loaded");
            bridgePINVOKEDynamic.errorlog = botlog;
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
            if (remotebot == null) return;
            try
            {
                remotebot.onStart();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onStart():", e);
            }
		}

		public void onInit() {
			bridge.Broodwar.printf("MonoBridgeAI Proxy Class Initialised");
            if (remotebot == null) return;
            try
            {
                remotebot.onInit();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onInit():", e);
            }
		}
		
		public void onEnd() {
            if (remotebot == null) return;
            try {
                remotebot.onEnd();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onEnd():", e);
            }
		}
		
		public void onFrame() {
            if (remotebot == null) return;
            try
            {
                remotebot.onFrame();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onFrame():", e);
            }
		}
		
		public Boolean onSendText(string text) {
            if (remotebot == null) return true;
            try
            {
                return remotebot.onSendText(text);
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onSendText():", e);
                return true;
            }
       
		}
		
        public void onUnitCreate() {
            if (remotebot == null) return;
            try {
                remotebot.onUnitCreate();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onUnitCreate():", e);
            }
		}
		
        public void onUnitDestroy() {
            if (remotebot == null) return;
            try {
                remotebot.onUnitDestroy();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onUnitDestroy():", e);
            }
		}
		public void onUnitMorph() {
            if (remotebot == null) return;
            try
            {
                remotebot.onUnitMorph();
            } 
            catch (Exception e)
            {
                botlog.Debug("Error in onUnitMorph():", e);
            }
		}
		public void onUnitShow() {
            if (remotebot == null) return;
            try
            {
                remotebot.onUnitShow();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onUnitShow():", e);
            }

		}
		public void onUnitHide() {
            if (remotebot == null) return;
            try
            {
                remotebot.onUnitHide();
            }
            catch (Exception e)
            {
                botlog.Debug("Error in onUnitHide():", e);
            }
		}
		
	}
}

