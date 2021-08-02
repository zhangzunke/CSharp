using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Singletons
{
    public class SingletonMain
    {
        public static void Run()
        {
            int size = 8;
            Task[] tasks = new Task[size];
            for (int i = 0; i < size; i++)
            {
                tasks[i] = Task.Run(() => MemoryCache.LazyCreate());
            }
            Task.WaitAll(tasks);
        }
    }
}
