using System;
using System.Collections.Generic;
using System.Text;
using BWAPI;

namespace BWAPI
{
    /**
     * Allows the BWAPI to call into the custom AI remote process
     */
    public class AIProxy: MarshalByRefObject
    {
        public static MonoStarcraftBotBase realbot;

        public AIProxy()
        {
            //setup our backlink to BWAPI
            BWAPI.bridgePINVOKEProxy.connectProxy();
        }
        
        public void onStart()
        {
            realbot.onStart();   
        }

        public void onInit()
        {
            
            bridge.Broodwar.printf("MonoBridgeAI Remote Proxy Class Initialised");

        }

        public void onEnd()
        {
            realbot.onEnd();
        }

        public void onFrame()
        {
            realbot.onFrame();
        }

        public Boolean onSendText(string text)
        {
            return realbot.onSendText(text);
        }

        public void onUnitCreate()
        {
            realbot.onUnitCreate(BWAPI.monobridgeutil.getLastUnitParam()); 
        }

        public void onUnitDestroy()
        {
            realbot.onUnitDestroy(BWAPI.monobridgeutil.getLastUnitParam());
        }
        public void onUnitMorph()
        {
           realbot.onUnitMorph(BWAPI.monobridgeutil.getLastUnitParam());
        }
        public void onUnitShow()
        {
            realbot.onUnitShow(BWAPI.monobridgeutil.getLastUnitParam());
        }
        public void onUnitHide()
        {
             realbot.onUnitHide(BWAPI.monobridgeutil.getLastUnitParam());
        }
    }
}
