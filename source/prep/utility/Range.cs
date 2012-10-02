using System;
using System.Collections.Generic;

namespace prep.utility
{
    public interface Range<in Item> : IComparable<>
    {
        // how are all the ways you need to look at a range?
        // >, >=, <, <=, no upper bounds, no lower bounds, 
        bool lowEnd;
        bool highEnd;

    }
}
