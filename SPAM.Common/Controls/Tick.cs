using System;
using System.Threading;

namespace SPAM.Common.Controls
{
    public delegate void MyThreadTick(int nTick);

    class Tick
    {
        private bool _ThreadStart;
        private int _Interval;
        public const int MAXTICK = 10000;

        public event MyThreadTick eTick;

        public bool ThreadStart
        {
            get
            {
                return _ThreadStart;
            }
            set
            {
                _ThreadStart = value;
                if (value)
                {
                    StartThread();
                }
            }
        }
        public int Interval
        {
            get { return _Interval; }
            set { _Interval = value; }
        }

        private int nTick;        

        Thread t;

        public Tick()
        {

        }

        private void StartThread()
        {
            t = new Thread(MyProc);
            t.Start();
        }

        private void MyProc()
        {
            while (ThreadStart)
            {
                Thread.Sleep(Interval);

                try
                {
                    if (eTick != null)
                    {
                        nTick = (nTick + 1) % MAXTICK;

                        nTick = nTick == 0 ? MAXTICK : nTick;
                        
                        eTick(nTick);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
