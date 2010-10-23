using System;
using System.ComponentModel;
using BWAPI;

namespace StarcraftBot.Terrain
{
	class Analyzer
	{
		public event EventHandler Done;
		BackgroundWorker bwBWTA;

		public Analyzer()
		{
		}

		public void Run()
		{
			bridge.readMap();
			bwBWTA = new BackgroundWorker();
			bwBWTA.WorkerReportsProgress = false;
			bwBWTA.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwBWTA_RunWorkerCompleted);
			bwBWTA.DoWork += new DoWorkEventHandler(bwBWTA_DoWork);
			bwBWTA.RunWorkerAsync();
			Util.Logger.Instance.Log("BWTA Terrain analysis Started");
		}

		void bwBWTA_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker bw = sender as BackgroundWorker;
			bridge.analyze();
		}

		void bwBWTA_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Util.Logger.Instance.Log("BWTA Terrain analysis Completed");
			if (Done != null)
				Done(this, EventArgs.Empty);
		}
	}
}
