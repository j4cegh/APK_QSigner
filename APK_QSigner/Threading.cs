using System;
using System.Threading;

namespace APK_QSigner
{
    public static class Threading
    {
        public static void RunWithThread(Action ac)
        {
            new Thread(new ThreadStart(ac)).Start();
        }
    }
}