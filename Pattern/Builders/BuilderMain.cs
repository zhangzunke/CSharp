using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builders
{
    public class BuilderMain
    {
        public static void Run()
        {
            //var queryBuilder = new QueryBuilder();
            //var fromBuilder = new FormBuilder();
            var httpHeaderBuilder = new HttpHeaderBuilder();
            ConstructionProcess(httpHeaderBuilder);
            httpHeaderBuilder.Build().Dump();
        }

        public static void ConstructionProcess(IKeyValueCollectionBuilder builder)
        {
            builder.Add("make", "lada")
                .Add("color", "red")
                .Add("year", 1990.ToString());
        }
    }
}
