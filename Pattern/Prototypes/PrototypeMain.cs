using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototypes
{
    public class PrototypeMain
    {
        public static void Run()
        {
            var garden = new GardenFactory(
                new TreeSeed("Apple"),
                new GrassSeed("Green"),
                new FlowerSeed("Roses")
                );

            garden.CreatePlant1();
            garden.CreatePlant2();
            garden.CreatePlant3();


            List<IBlock> grid = new();
            grid.Add(BlockFactory.Create("Hello Word"));
            grid.Add(BlockFactory.Create("3"));
            grid.Add(BlockFactory.Create("11/02/1980"));

        }
    }
}
