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
            //var httpHeaderBuilder = new HttpHeaderBuilder();
            var dictionaryBuilder = new DictBuilder();
            ConstructionProcess(dictionaryBuilder);
            dictionaryBuilder.Build().Dump();

            var carBuilder = new CarBuilder();
            BuildRedLada1980(carBuilder);
            carBuilder.Build().Dump();
        }

        public static void ConstructionProcess(IKeyValueCollectionBuilder builder)
        {
            builder.Add("make", "lada")
                .Add("color", "red")
                .Add("year", 1990.ToString());
        }

        public static void BuildRedLada1980(ICarBuilder builder)
        {
            builder
                .SetMake("lada")
                .SetColour("red")
                .SetManifactureDate("01/01/1980");
        }
    }
}
