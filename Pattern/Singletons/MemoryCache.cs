using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Singletons
{
    public class MemoryCache
    {
        private static int i = 0;
        private static MemoryCache _instance;
        private static object _cacheLock = new object();

        private MemoryCache()
        {
            $"Created {i++}".Dump();
        }

        //static MemoryCache()
        //{
        //    _instance = new MemoryCache();
        //}

        /// <summary>
        /// Bad Example
        /// </summary>
        /// <returns></returns>
        public static MemoryCache BadCreate()
        {
            return _instance ?? (_instance = new MemoryCache());
        }

        public static MemoryCache Create()
        {
            return _instance;
        }

        public static MemoryCache LazyCreate()
        {
            if(_instance == null)
            {
                lock (_cacheLock)
                {
                    if(_instance == null)
                    {
                        _instance = new MemoryCache();
                    }
                }
            }
            return _instance;
        }
    }
}
