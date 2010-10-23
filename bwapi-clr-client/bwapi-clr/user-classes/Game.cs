namespace BWAPI
{

    using System;
    using System.Runtime.InteropServices;

    public partial class Game : IDisposable
    {
        public virtual void printf(string format, params object[] args)
        {
            string fullstr = String.Format(format, args);
            this.printf(fullstr);
        }

        public virtual void printf(string format, object arg0)
        {
            string fullstr = String.Format(format, arg0);
            this.printf(fullstr);
        }
    }
}