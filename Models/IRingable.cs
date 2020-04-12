using System;
using System.Collections.Generic;

namespace Phone.Models
{
    public interface IRingable
    {
        string Ring();
        string Unlock();
    }
}