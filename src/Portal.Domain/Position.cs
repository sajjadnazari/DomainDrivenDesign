using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain
{
    public enum PositionState
    {
        None = 0,
        X = 1,
        O = 2
    }
    public enum PositionType
    {
        None = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9
    }
    public class Position
    {
        public PositionState State { get; set; }
        public PositionType Type { get; set; }
    }
}
