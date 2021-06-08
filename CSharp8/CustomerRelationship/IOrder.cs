using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.CustomerRelationship
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
