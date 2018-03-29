using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OderingSystem.Context
{
    public class SingleShuNiuContext
    {
        private static SingleShuNiuContext instance = null;
        private static readonly object obj = new object();
        private static ShuNiuContext context = null;
        public static SingleShuNiuContext CreateInstance()
        {
            if (instance==null)
            {
                lock (obj)
                {
                    instance = new SingleShuNiuContext();
                }
            }
            return instance;
        }

        private SingleShuNiuContext()
        {
            context = new ShuNiuContext();
        }

        public void Set(ShuNiuContext entry)
        {
            lock (obj)
            {
                if (entry!=null)
                {
                    context = entry;
                }
            }
        }

        public ShuNiuContext Get()
        {
            return context;
        }

    }
}