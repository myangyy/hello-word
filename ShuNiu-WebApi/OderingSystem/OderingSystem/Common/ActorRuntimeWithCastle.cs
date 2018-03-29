using Castle.MicroKernel;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OderingSystem.Common
{
    public class ActorRuntimeWithCastle
    {
        private static readonly object locker = new object();
        private static ActorRuntimeWithCastle instance;
        private static IWindsorContainer container;
        private static IKernel kernel;
        public ActorRuntimeWithCastle(string file)
        {
            XmlInterpreter inter = new XmlInterpreter(file);
            container = new WindsorContainer(inter);
        }

        public static ActorRuntimeWithCastle CreateInstance(string key)
        {
            if (instance==null)
            {
                lock (locker)
                {
                    instance = new ActorRuntimeWithCastle(key);
                }
            }
            return instance;
        }

        public T Resolve<T>(string key)
        {
            return container.Resolve<T>(key);
        }
    }
}