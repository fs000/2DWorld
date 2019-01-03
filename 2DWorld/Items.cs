using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DWorld {

    [Flags]
    public enum Items {

        Food = 1,
        Guns = 2,
        Enemy = 4,
        Trap = 8
    }
}
