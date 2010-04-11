using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace StarcraftBotHost
{
    public partial class FM_Main : Form
    {
        public FM_Main()
        {
            InitializeComponent();
        }

        private void AddStatus(string status)
        {
            ED_Status.Text = ED_Status.Text + status + "\r\n";
        }

        private void FM_Main_Shown(object sender, EventArgs e)
        {
            //setup AI proxy with our real bot ready to take a connection
            AddStatus("Initialising..");
            AddStatus("Create AI Module..");
            StarcraftBot.MonoStarcraftBot bot = new StarcraftBot.MonoStarcraftBot();
            BWAPI.AIProxy.realbot = bot;
            //tell .net remoting about our class.
            AddStatus("Setting Up AI Remoting..");

            if (System.IO.File.Exists("StarcraftBotHost.exe.config"))
            {
                AddStatus("Found Config file using \"StarcraftBotHost.exe.config\"");
                RemotingConfiguration.Configure("StarcraftBotHost.exe.config");
            }
            else
            {
                AddStatus("Config file not found. Hosting on tcp://localhost:8989/aiproxy.rem and connecting to tcp://localhost:48989/bwapi.rem");
               
                //setup AIProxy
                TcpServerChannel channel = new TcpServerChannel("AIProxy",8989);
                ChannelServices.RegisterChannel(channel,false);
                RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(BWAPI.AIProxy),
                "aiproxy.rem",
                WellKnownObjectMode.Singleton);

                //inform ourselves about BWAPI
                RemotingConfiguration.RegisterWellKnownClientType(typeof(BWAPI.bridgePINVOKEDynamic), "tcp://localhost:48989/bwapi.rem");
            }

            //we are passive now. let .net remoting and the starcraft process take over.
            AddStatus("Accepting Connections..");
        }
    }
}
