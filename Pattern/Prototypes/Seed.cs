using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototypes
{
    public abstract class Seed
    {
        public abstract Seed Copy();
    }

    public class TreeSeed : Seed
    {
        public string Type { get; }
        public TreeSeed(string type) => Type = type;
        public override Seed Copy() => new TreeSeed(Type);
    }

    public class GrassSeed : Seed
    {
        public string Type { get; }
        public GrassSeed(string type) => Type = type;
        public override Seed Copy() => new GrassSeed(Type);
    }

    public class FlowerSeed : Seed
    {
        public string Type { get; }
        public FlowerSeed(string type) => Type = type;
        public override Seed Copy() => new FlowerSeed(Type);
    }
}
